using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadrusMotorCompany.Core.Enums
{
    public enum VehicleMake
    {
        [System.Runtime.Serialization.EnumMemberAttribute()]
        [System.ComponentModel.Description("Ford")]
        Ford
    }

    public enum VehicleModel
    {
        [System.Runtime.Serialization.EnumMemberAttribute()]
        [System.ComponentModel.Description("F-150")]
        F150
    }

    public enum VehiclePackage
    {
        [System.Runtime.Serialization.EnumMemberAttribute()]
        [System.ComponentModel.Description("XL")]
        XL
    }

    public enum VehicleType
    {
        [System.Runtime.Serialization.EnumMemberAttribute()]
        [System.ComponentModel.Description("Truck")]
        Truck
    }
}
