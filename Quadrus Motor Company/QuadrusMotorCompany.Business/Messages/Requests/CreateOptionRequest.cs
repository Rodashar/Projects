using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class CreateOptionRequest : ServiceRequest
    {
        public Option OptionToCreate { get; set; }

        public override bool CanProcessRequest()
        {
            return OptionToCreate != null && OptionToCreate.Id != default(Guid);
        }
    }
}
