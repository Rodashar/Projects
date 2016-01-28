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

        public DbSet<QuadrusMotorCompany.Domain.Vehicle> Vehicles { get; set; }
        public DbSet<QuadrusMotorCompany.Domain.Option> Options { get; set; }
        public DbSet<QuadrusMotorCompany.Domain.Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
