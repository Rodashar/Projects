using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Interfaces
{
    public interface IOrderOptionRepository
    {
        OrderOption GetByOrderIdOptionId(Guid orderId, Guid optionId);
        IEnumerable<OrderOption> GetByOrderId(Guid orderId);
        IEnumerable<OrderOption> GetByOptionId(Guid optionid);
        OrderOption CreateOrderOption(OrderOption orderOptionToCreate);
        void UpdateOrderOption(OrderOption orderOptionToUpdate);
        void DeleteOrderOption(Guid orderId, Guid optionId);
        void DeleteOrderOption(OrderOption orderOptionToDelete);
    }
}
