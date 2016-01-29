using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class CreateVehicleOptionRequest : ServiceRequest
    {
        public VehicleOption VehicleOptionToCreate { get; set; }

        public override bool CanProcessRequest()
        {
            return VehicleOptionToCreate != null 
                && (VehicleOptionToCreate.VehicleId != default(Guid) && VehicleOptionToCreate.OptionId != default(Guid));
        }
    }
}
