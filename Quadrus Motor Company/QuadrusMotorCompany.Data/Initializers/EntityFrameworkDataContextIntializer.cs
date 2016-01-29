using QuadrusMotorCompany.Core.Enums;
using QuadrusMotorCompany.Data.Contexts;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Initializers
{
    public class EntityFrameworkDataContextIntializer : DropCreateDatabaseAlways<EntityFrameworkDataContext>
    {
        protected override void Seed(EntityFrameworkDataContext context)
        {
            IList<Vehicle> defaultVehicles = new List<Vehicle>();
            IList<Option> defaultOptions = new List<Option>();
            IList<VehicleOption> defaultVehicleOptions = new List<VehicleOption>();

            //Vehicles
            defaultVehicles.Add(new Vehicle()
                {
                    Id = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    Make = VehicleMake.Ford,
                    Model = VehicleModel.F150,
                    Package = VehiclePackage.XL,
                    Year = 2015,
                    Description = @"&lt;li&gt;Electronic-shift-on-the-fly&lt;/li&gt;
                                    &lt;li&gt;Heavy duty shock absorbers&lt;/li&gt;
                                    &lt;li&gt;17in silver painted styled steel wheels&lt;/li&gt;
                                    &lt;li&gt;Sterling silver metallic front & rear step bumpers&lt;/li&gt;
                                    &lt;li&gt;Black bar-style grille w/ black surround&lt;/li&gt;
                                    &lt;li&gt;Power 4-wheel, vented-disc, anti-lock brakes&lt;/li&gt;
                                    &lt;li&gt;AM/FM stereo&lt;/li&gt;
                                    &lt;li&gt;Air conditioning&lt;/li&gt;",
                    BasePrice = 28599,
                    Type = VehicleType.Truck,
                    CreateOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            //Options
            defaultOptions.Add(new Option()
                {
                    Id = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6a"),
                    Name = "4.6L V8 Engine",
                    Description = @"&lt;li&gt;6-speed automatic transmission&lt;/li&gt;
                                    &lt;li&gt;292 hp and 320 lb.-ft. of torque&lt;/li&gt;
                                    &lt;li&gt;9.7L/100km highway and 14.3L/100km city&lt;/li&gt;
                                    &lt;li&gt;Maximum towing of 4,309 kg (9,500 lbs.)&lt;/li&gt;",
                    Price = 0,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            defaultOptions.Add(new Option()
                {
                    Id = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6b"),
                    Name = "Decor Package",
                    Description = @"&lt;li&gt;Chrome Front & Rear Bumpers&lt;/li&gt;
                                    &lt;li&gt;Cloth 40/20/40 Split Bench Seat&lt;/li&gt;
                                    &lt;li&gt;Includes front molded-in-color block upper fascia and rear step pad&lt;/li&gt;",
                    Price = 150,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            defaultOptions.Add(new Option()
                {
                    Id = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6c"),
                    Name = "Trailer Tow Package",
                    Description = @"&lt;li&gt;Required for towing over 5,000 lbs.&lt;/li&gt;
                                    &lt;li&gt;•	Includes class N trailer hitch receiver (bumper mounted) 7-pin wiring&lt;/li&gt;",
                    Price = 480,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            defaultOptions.Add(new Option()
                {
                    Id = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6d"),
                    Name = "Cargo Management System ",
                    Description = @"&lt;li&gt;Includes 4 tie-down cleats&lt;/li&gt;",
                    Price = 230,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            defaultOptions.Add(new Option()
                {
                    Id = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6e"),
                    Name = "Monthly Special Discount ",
                    Description = @"&lt;li&gt;Discount for pre-configured monthly specials only&lt;/li&gt;",
                    Price = 250,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Clayton Page",
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = "Clayton Page"
                });

            //Vehicle Options
            defaultVehicleOptions.Add(new VehicleOption()
                {
                    VehicleId = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    OptionId = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6a")
                });

            defaultVehicleOptions.Add(new VehicleOption()
                {
                    VehicleId = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    OptionId = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6b")
                });

            defaultVehicleOptions.Add(new VehicleOption()
                {
                    VehicleId = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    OptionId = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6c")
                });

            defaultVehicleOptions.Add(new VehicleOption()
                {
                    VehicleId = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    OptionId = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6d")
                });

            defaultVehicleOptions.Add(new VehicleOption()
                {
                    VehicleId = new Guid("f233d998-fc83-4242-aafb-5a353b2c205c"),
                    OptionId = new Guid("e9c782cd-f40c-4d3a-93ab-b758d7872a6e")
                });

            context.Vehicles.AddRange(defaultVehicles);
            context.Options.AddRange(defaultOptions);
            context.VehicleOptions.AddRange(defaultVehicleOptions);

            base.Seed(context);
        }
    }
}
