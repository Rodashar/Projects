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
            var vehicle = FindFirstOrDefault(x => x.Id == id);

            vehicle.Options = (from option in this._dataContext.Options
                               join vehicleOption in this._dataContext.VehicleOptions on option.Id equals vehicleOption.OptionId
                               where vehicleOption.VehicleId == id
                               select option)
                               .ToList();

            return vehicle;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return GetAll();
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
