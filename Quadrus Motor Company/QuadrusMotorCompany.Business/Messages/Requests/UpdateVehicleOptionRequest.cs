using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class UpdateVehicleOptionRequest : ServiceRequest
    {
        public VehicleOption VehicleOptionToUpdate { get; set; }

        public override bool CanProcessRequest()
        {
            return VehicleOptionToUpdate != null 
                && (VehicleOptionToUpdate.VehicleId != default(Guid) && VehicleOptionToUpdate.OptionId != default(Guid));
        }
    }
}
