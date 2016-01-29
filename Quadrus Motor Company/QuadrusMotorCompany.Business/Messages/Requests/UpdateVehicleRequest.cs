using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class UpdateVehicleRequest : ServiceRequest
    {
        public Vehicle VehicleToUpdate { get; set; }

        public override bool CanProcessRequest()
        {
            return VehicleToUpdate != null && VehicleToUpdate.Id != default(Guid);
        }
    }
}
