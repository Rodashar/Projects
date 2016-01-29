using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using QuadrusMotorCompany.Business.Services.Interfaces;
using QuadrusMotorCompany.Data.Repositories.Interfaces;
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

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public ServiceResponse<OrderResponse> FindOrder(FindOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<OrderResponse> CreateOrder(CreateOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateOrder(UpdateOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> CancelOrder(CancelOrderRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
