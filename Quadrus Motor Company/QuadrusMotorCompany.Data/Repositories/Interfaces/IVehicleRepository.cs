using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Vehicle GetById(Guid id);
        IEnumerable<Vehicle> GetVehicles();
        Vehicle CreateVehicle(Vehicle vehicleToCreate);
        Vehicle UpdateVehicle(Vehicle vehicleToDelete);
    }
}
