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
            throw new NotImplementedException();
        }

        public Order GetNextOrder()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders(System.Linq.Expressions.Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Order CreateVehicle(Order orderToCreate)
        {
            throw new NotImplementedException();
        }

        public Order UpdateVehicle(Order orderToUpdate)
        {
            throw new NotImplementedException();
        }

        public Order CancelOrder(Order orderToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
