using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Services.Interfaces
{
    public interface IOrderService
    {
        ServiceResponse<OrderResponse> FindOrder(FindOrderRequest request);
        ServiceResponse<OrdersResponse> FindOrders(FindOrderByCustomerRequest request);
        ServiceResponse<OrdersResponse> GetAllOrders(GetAllOrdersRequest request);
        ServiceResponse<OrdersResponse> GetPendingOrders(GetPendingOrdersRequest request);
        ServiceResponse<OrdersResponse> GetCompletedOrders(GetCompletedOrdersRequest request);
        ServiceResponse<OrderResponse> CreateOrder(CreateOrderRequest request);
        ServiceResponse<RequestSuccessfulResponse> UpdateOrder(UpdateOrderRequest request);
        ServiceResponse<RequestSuccessfulResponse> CancelOrder(CancelOrderRequest request);
        ServiceResponse<RequestSuccessfulResponse> CompleteOrder(CompleteOrderRequest request);
    }
}
