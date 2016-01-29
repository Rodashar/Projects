using QuadrusMotorCompany.Data.Initializers;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Contexts
{
    public class EntityFrameworkDataContext : DbContext
    {
        public EntityFrameworkDataContext() : base("name=EntityFrameworkDataContext")
        {
            Database.SetInitializer<EntityFrameworkDataContext>(new EntityFrameworkDataContextIntializer());
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<VehicleOption> VehicleOptions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderOption> OrderOptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
