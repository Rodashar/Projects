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
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public Vehicle GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateVehicle(Vehicle vehicleToCreate)
        {
            throw new NotImplementedException();
        }

        public Vehicle UpdateVehicle(Vehicle vehicleToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
