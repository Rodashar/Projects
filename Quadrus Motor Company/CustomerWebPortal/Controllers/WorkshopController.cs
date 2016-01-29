using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using QuadrusMotorCompany.Business.Services.Interfaces;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CustomerWebPortal.Controllers
{
    public class WorkshopController : Controller
    {
        private IVehicleService _vehicleService;
        private IOrderService _orderService;

        public WorkshopController(IVehicleService vehicleService, IOrderService orderService)
        {
            this._vehicleService = vehicleService;
            this._orderService = orderService;
        }

        // GET: Workshop
        public ActionResult Index()
        {
            var orders = GetOrders("Pending");

            ViewBag.Orders = orders;

            return View();
        }

        public ActionResult Orders(String filter)
        {
            var orders = GetOrders(filter);

            ViewBag.Orders = orders;

            return View();
        }

        public ActionResult Order(Guid id)
        {
            var orderRequest = this._orderService.FindOrder(new FindOrderRequest()
                {
                    OrderId = id
                });

            if (!orderRequest.IsResponseSuccessfull)
                RedirectToAction("Orders");

            var vehicleRequest = this._vehicleService.FindVehicle(new FindVehicleRequest() { VehicleId = orderRequest.Response.Order.VehicleId });

            if (!vehicleRequest.IsResponseSuccessfull)
                RedirectToAction("Orders");

            ViewBag.Order = orderRequest.Response.Order;
            ViewBag.Vehicle = vehicleRequest.Response.Vehicle;

            return View();
        }

        public ActionResult CompleteOrder(Guid id)
        {
            var completeOrderRequest = this._orderService.CompleteOrder(new CompleteOrderRequest()
                {
                    OrderId = id
                });

            if (!completeOrderRequest.IsResponseSuccessfull)
                ViewBag.ErrorMessage = "There was an error completing this request. Please check the log files and try the action again.";

            return View();
        }

        private IEnumerable<Order> GetOrders(String filter)
        {
            ServiceResponse<OrdersResponse> ordersRequest = null;
            var orders = Enumerable.Empty<Order>();

            switch (filter)
            {
                case "All":
                    ordersRequest = this._orderService.GetAllOrders(new GetAllOrdersRequest() { });
                    break;

                case "Completed":
                    ordersRequest = this._orderService.GetCompletedOrders(new GetCompletedOrdersRequest() { });
                    break;
                case "Pending":
                default:
                    ordersRequest = this._orderService.GetPendingOrders(new GetPendingOrdersRequest() { });
                    break;
            }

            if (ordersRequest.IsResponseSuccessfull)
                orders = ordersRequest.Response.Orders;

            return orders;
        }
    }
}
