using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Services.Interfaces;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerWebPortal.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleService _vehicleService;
        private IOrderService _orderService;
        private IOptionService _optionService;

        public HomeController(IVehicleService vehicleService, IOrderService orderService, IOptionService optionService)
        {
            this._vehicleService = vehicleService;
            this._orderService = orderService;
            this._optionService = optionService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vehicles()
        {
            var vehiclesRequest = this._vehicleService.GetAllVehicles(new GetAllVehiclesRequest() { });
            var vehicles = Enumerable.Empty<Vehicle>();

            if (vehiclesRequest.IsResponseSuccessfull)
                vehicles = vehiclesRequest.Response.Vehicles;

            ViewBag.Vehicles = vehicles;

            return View();
        }

        public ActionResult OrderVehicle(Guid id)
        {
            if (id == default(Guid))
                RedirectToAction("Vehicles");

            var vehicleRequest = this._vehicleService.FindVehicle(new FindVehicleRequest()
                {
                    VehicleId = id
                });

            if(!vehicleRequest.IsResponseSuccessfull || vehicleRequest.Response.Vehicle == null)
            {
                //Log the request
                ViewBag.ErrorMessage = "There was an error retrieving the vehicle. Please contact a member of our sales team at (555) 555-5555 for help with ordering your vehicle.";
            }

            ViewBag.Vehicle = vehicleRequest.Response.Vehicle;


            return View();
        }

        public ActionResult CreateOrder()
        {
            if (!Request.Form.AllKeys.Contains("SelectedOptions"))
                throw new Exception();

            if (!Request.Form.AllKeys.Contains("VehicleId"))
                throw new Exception();

            if (!Request.Form.AllKeys.Contains("FullNameTextBox"))
                throw new Exception();

            List<Option> selectedOptions = new List<Option>();
            String customer = Request.Form["FullNameTextBox"].ToString();
            Double vehiclePrice = Double.Parse(Request.Form["VehiclePrice"].ToString());

            foreach(var optionId in Request.Form["SelectedOptions"].ToString().Split(','))
            {
                var optionRequest = this._optionService.FindOption(new FindOptionRequest() { OptionId = new Guid(optionId) });

                if (optionRequest.IsResponseSuccessfull)
                    selectedOptions.Add(optionRequest.Response.Option);
            }

            Double subTotal = vehiclePrice + selectedOptions.Sum(x => x.Price);

            var order = new Order()
                            {
                                VehicleId = new Guid(Request.Form["VehicleId"].ToString()),
                                Customer = customer,
                                Options = selectedOptions,
                                SubTotal = subTotal,
                                Salestax = subTotal * 0.05,
                                CreatedOn = DateTime.Now,
                                CreatedBy = customer,
                                ModifiedOn = DateTime.Now,
                                ModifiedBy = customer
                            };

            var createOrderRequest = this._orderService.CreateOrder(new CreateOrderRequest()
                {
                    OrderToCreate = order
                });

            if (!createOrderRequest.IsResponseSuccessfull)
            {
                ViewBag.ErrorMessage = "There was an error creating your order. Please contact a member of our sales team at (555) 555-5555 for help with ordering your vehicle.";

                return View();
            }

            return View("OrderComplete");
        }
    }
}
