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
    public class VehicleOptionRepository : GenericRepository<VehicleOption>, IVehicleOptionRepository
    {
        public VehicleOption GetByVehicleIdOptionId(Guid vehicleId, Guid optionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleOption> GetByVehicleId(Guid vehicleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleOption> GetByOptionId(Guid optionid)
        {
            throw new NotImplementedException();
        }

        public VehicleOption CreateVehicle(VehicleOption vehicleOptionToCreate)
        {
            throw new NotImplementedException();
        }

        public VehicleOption UpdateVehicle(VehicleOption vehicleOptionToUpdate)
        {
            throw new NotImplementedException();
        }

        public VehicleOption CancelOrder(VehicleOption vehicleOptionToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
