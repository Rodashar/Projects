using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Interfaces
{
    public interface IVehicleOptionRepository
    {
        VehicleOption GetByVehicleIdOptionId(Guid vehicleId, Guid optionId);
        IEnumerable<VehicleOption> GetByVehicleId(Guid vehicleId);
        IEnumerable<VehicleOption> GetByOptionId(Guid optionid);
        VehicleOption CreateVehicle(VehicleOption vehicleOptionToCreate);
        VehicleOption UpdateVehicle(VehicleOption vehicleOptionToUpdate);
        VehicleOption CancelOrder(VehicleOption vehicleOptionToDelete);
    }
}
