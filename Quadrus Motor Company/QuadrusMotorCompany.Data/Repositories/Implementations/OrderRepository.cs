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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public Order GetById(Guid id)
        {
            var order = FindFirstOrDefault(x => x.Id == id);

            order.Options = (from option in this._dataContext.Options
                             join orderOption in this._dataContext.OrderOptions on option.Id equals orderOption.OptionId
                             where orderOption.OrderId == id
                             select option)
                             .ToList();

            return order;
        }

        public Order GetNextOrder()
        {
            return FindBy(x => x.CompletionDate == null)
                    .OrderByDescending(x => x.CreatedOn)
                    .FirstOrDefault();
        }

        public IEnumerable<Order> GetOrders()
        {
            return GetAll();
        }

        public IEnumerable<Order> GetOrders(System.Linq.Expressions.Expression<Func<Order, bool>> predicate)
        {
            return FindBy(predicate);
        }

        public Order CreateOrder(Order orderToCreate)
        {
            //ToDo: validate order
            return Create(orderToCreate);
        }

        public void UpdateOrder(Order orderToUpdate)
        {
            //ToDo: validate order
            Update(orderToUpdate, orderToUpdate.Id);
        }

        public void DeleteOrder(Guid orderId)
        {
            var order = FindBy(orderId);

            DeleteOrder(order);
        }

        public void DeleteOrder(Order orderToDelete)
        {
            Delete(orderToDelete);
        }
    }
}
