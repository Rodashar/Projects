using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Generics
{
    public abstract class ServiceRequest
    {
        public abstract Boolean CanProcessRequest();
    }
}
