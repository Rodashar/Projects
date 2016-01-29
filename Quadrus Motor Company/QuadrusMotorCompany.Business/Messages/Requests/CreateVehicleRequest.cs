using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class CreateVehicleRequest : ServiceRequest
    {
        public Vehicle VehicleToCreate { get; set; }

        public override bool CanProcessRequest()
        {
            return VehicleToCreate != null && VehicleToCreate.Id != default(Guid);
        }
    }
}
