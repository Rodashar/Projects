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
        Order CreateVehicle(Order orderToCreate);
        Order UpdateVehicle(Order orderToUpdate);
        Order CancelOrder(Order orderToDelete);
    }
}
