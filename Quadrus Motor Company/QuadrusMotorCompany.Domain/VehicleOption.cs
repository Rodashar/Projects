using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Domain
{
    public class VehicleOption
    {
        [Key]
        public Guid VehicleId { get; set; }

        [Key]
        public Guid OptionId { get; set; }
    }
}
