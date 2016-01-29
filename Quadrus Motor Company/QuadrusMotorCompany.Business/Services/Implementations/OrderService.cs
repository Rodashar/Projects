using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using QuadrusMotorCompany.Business.Services.Interfaces;
using QuadrusMotorCompany.Data.Repositories.Interfaces;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderOptionRepository _orderOptionRepository;

        public OrderService(IOrderRepository orderRepository, IOrderOptionRepository orderOptionRepository)
        {
            this._orderRepository = orderRepository;
            this._orderOptionRepository = orderOptionRepository;
        }

        public ServiceResponse<OrderResponse> FindOrder(FindOrderRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OrderResponse>(new OrderResponse()
                {
                    Order = this._orderRepository.GetById(request.OrderId)
                });
        }

        public ServiceResponse<OrdersResponse> FindOrders(FindOrderByCustomerRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OrdersResponse>(new OrdersResponse()
                {
                    Orders = this._orderRepository.GetOrders(x => x.Customer == request.CustomerName)
                });
        }

        public ServiceResponse<OrdersResponse> GetAllOrders(GetAllOrdersRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OrdersResponse>(new OrdersResponse()
                {
                    Orders = this._orderRepository.GetOrders()
                });
        }

        public ServiceResponse<OrdersResponse> GetPendingOrders(GetPendingOrdersRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OrdersResponse>(new OrdersResponse()
                {
                    Orders = this._orderRepository.GetOrders(x=> x.CompletionDate == null)
                });
        }

        public ServiceResponse<OrdersResponse> GetCompletedOrders(GetCompletedOrdersRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OrdersResponse>(new OrdersResponse()
                {
                    Orders = this._orderRepository.GetOrders(x => x.CompletionDate != null)
                });
        }

        public ServiceResponse<OrderResponse> CreateOrder(CreateOrderRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            if (request.OrderToCreate.Id == default(Guid))
                request.OrderToCreate.Id = Guid.NewGuid();

            this._orderRepository.CreateOrder(request.OrderToCreate);

            foreach(var option in request.OrderToCreate.Options)
            {
                this._orderOptionRepository.CreateOrderOption(new OrderOption()
                    {
                        OrderId = request.OrderToCreate.Id,
                        OptionId = option.Id
                    });
            }

            return new ServiceResponse<OrderResponse>(new OrderResponse()
                {
                    Order = request.OrderToCreate
                });
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateOrder(UpdateOrderRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            this._orderRepository.UpdateOrder(request.OrderToUpdate);

            return new ServiceResponse<RequestSuccessfulResponse>(new RequestSuccessfulResponse() {});
        }

        public ServiceResponse<RequestSuccessfulResponse> CancelOrder(CancelOrderRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            this._orderRepository.DeleteOrder(request.OrderId);

            return new ServiceResponse<RequestSuccessfulResponse>(new RequestSuccessfulResponse() { });
        }

        public ServiceResponse<RequestSuccessfulResponse> CompleteOrder(CompleteOrderRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            var order = this._orderRepository.GetById(request.OrderId);

            order.CompletionDate = DateTime.Now;

            this._orderRepository.UpdateOrder(order);

            return new ServiceResponse<RequestSuccessfulResponse>(new RequestSuccessfulResponse() { });
        }
    }
}
