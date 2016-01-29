using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Order GetById(Guid id);
        Order GetNextOrder();
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(Expression<Func<Order, bool>> predicate);
        Order CreateOrder(Order orderToCreate);
        void UpdateOrder(Order orderToUpdate);
        void DeleteOrder(Guid orderId);
        void DeleteOrder(Order orderToDelete);
    }
}
