using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Contexts
{
    public class EntityFrameworkDataContext : DbContext
    {
        public EntityFrameworkDataContext() : base("EntityFrameworkDataContext")
        { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<VehicleOption> VehicleOptions { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
