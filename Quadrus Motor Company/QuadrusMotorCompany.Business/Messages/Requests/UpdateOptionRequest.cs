using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class UpdateOptionRequest : ServiceRequest
    {
        public Option OptionToUpdate { get; set; }

        public override bool CanProcessRequest()
        {
            return OptionToUpdate != null && OptionToUpdate.Id != default(Guid);
        }
    }
}
