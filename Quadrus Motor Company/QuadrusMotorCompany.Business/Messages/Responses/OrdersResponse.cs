﻿using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Responses
{
    public class OrdersResponse
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
