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
        VehicleOption CreateVehicleOption(VehicleOption vehicleOptionToCreate);
        void UpdateVehicleOption(VehicleOption vehicleOptionToUpdate);
        void DeleteVehicleOption(Guid vehicleId, Guid optionId);
        void DeleteVehicleOption(VehicleOption vehicleOptionToDelete);
    }
}
