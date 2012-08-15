using System;
using System.ComponentModel;
using System.Reflection;

namespace SampleApplication.Objects.Tools
{
    public static class EnumExtentions
    {
        public static string ToDiscription(this Enum value)
        {
            var description = string.Empty;
            FieldInfo fi = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute),false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            else
            {
                description = value.ToString();
            }
            return description;
        }
    }
}
