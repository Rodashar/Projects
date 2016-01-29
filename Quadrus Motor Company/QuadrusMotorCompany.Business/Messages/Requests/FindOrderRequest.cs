using QuadrusMotorCompany.Business.Messages.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class FindOrderRequest : ServiceRequest
    {
        public Guid OrderId { get; set; }

        public override bool CanProcessRequest()
        {
            return OrderId != default(Guid);
        }
    }
}
