using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QuadrusMotorCompany.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string Description(this Enum source)
        {
            FieldInfo fi = null;

            if (source == null)
            {
                return String.Empty;
            }

            fi = source.GetType().GetField(source.ToString());

            if (fi == null)
            {
                return String.Empty;
            }

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return source.ToString();
            }
        }
    }
}
