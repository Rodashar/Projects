using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrusMotorCompany.Core.Extensions;
using System.ComponentModel.DataAnnotations;
using QuadrusMotorCompany.Core.Enums;

namespace QuadrusMotorCompany.Domain
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public VehicleMake Make { get; set; }

        [Required]
        public VehicleModel Model { get; set; }

        [Required]
        public VehiclePackage Package { get; set; }

        [Required]
        public Int32 Year { get; set; }

        public String DisplayName
        {
            get
            {
                return String.Format("{0} {1} {2} {3}",
                    Year.ToString(), Make.Description(), Model.Description(), Package.Description());
            }
        }

        public String Description { get; set; }

        [Required]
        public Int32 BasePrice { get; set; }

        [Required]
        public VehicleType Type { get; set; }

        [Required]
        public DateTime CreateOn { get; set; }

        [Required]
        public String CreatedBy { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public String ModifiedBy { get; set; }

        public IEnumerable<Option> Options { get; set; }
    }
}
