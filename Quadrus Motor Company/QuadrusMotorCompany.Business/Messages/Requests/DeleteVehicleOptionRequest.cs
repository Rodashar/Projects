using QuadrusMotorCompany.Business.Messages.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class DeleteVehicleOptionRequest : ServiceRequest
    {
        public Guid VehicleId { get; set; }

        public override bool CanProcessRequest()
        {
            return VehicleId != default(Guid);
        }
    }
}
