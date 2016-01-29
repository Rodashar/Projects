using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Domain
{
    public class OrderOption
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OptionId { get; set; }
    }
}
