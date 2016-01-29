using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Requests
{
    public class CreateOrderRequest : ServiceRequest
    {
        public Order OrderToCreate { get; set; }

        public override bool CanProcessRequest()
        {
            return OrderToCreate != null && OrderToCreate.Id != default(Guid);
        }
    }
}
