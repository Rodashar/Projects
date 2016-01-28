using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Domain
{
    public class Option
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }

        public String Description { get; set; }

        [Required]
        public Int32 Price { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public String CreatedBy { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public String ModifiedBy { get; set; }
    }
}
