using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Domain
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid VehicleId { get; set; }

        [Required]
        public String Customer { get; set; }

        public IEnumerable<Option> Options { get; set; }

        [Required]
        public Double SubTotal { get; set; }

        [Required]
        public Double Salestax { get; set; }

        public Double TotalPrice
        {
            get
            {
                return SubTotal + Salestax;
            }
        }

        public Nullable<DateTime> CompletionDate { get; set; }

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
