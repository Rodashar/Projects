using QuadrusMotorCompany.Data.Repositories.Generics;
using QuadrusMotorCompany.Data.Repositories.Interfaces;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Implementations
{
    public class OrderOptionRepository : GenericRepository<OrderOption>, IOrderOptionRepository
    {
        public OrderOption GetByOrderIdOptionId(Guid orderId, Guid optionId)
        {
            return FindFirstOrDefault(x => x.OrderId == orderId && x.OptionId == optionId);
        }

        public IEnumerable<OrderOption> GetByOrderId(Guid orderId)
        {
            return FindBy(x => x.OrderId == orderId).ToList();
        }

        public IEnumerable<OrderOption> GetByOptionId(Guid optionid)
        {
            return FindBy(x => x.OptionId == optionid).ToList();
        }

        public OrderOption CreateOrderOption(OrderOption orderOptionToCreate)
        {
            return Create(orderOptionToCreate);
        }

        public void UpdateOrderOption(OrderOption orderOptionToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderOption(Guid orderId, Guid optionId)
        {
            var option = GetByOrderIdOptionId(orderId, optionId);

            DeleteOrderOption(option);
        }

        public void DeleteOrderOption(OrderOption orderOptionToDelete)
        {
            Delete(orderOptionToDelete);
        }
    }
}
