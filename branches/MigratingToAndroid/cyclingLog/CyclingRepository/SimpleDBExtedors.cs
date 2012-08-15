
using System;
using System.Collections.Generic;
using System.Linq;
using Attribute = Amazon.SimpleDB.Model.Attribute;

namespace CyclingRepository
{
    public static class SimpleDBExtedors
   {

       public static string GetValueByName(this IList<Attribute> myAttributes, string name)
       {
           string myValue = (from attribute in myAttributes
                             where attribute.Name == name
                             select attribute.Value).DefaultIfEmpty(string.Empty).FirstOrDefault();
           return myValue;
       }


        public static double GetDoubleValueByName(this IList<Attribute> myAttributes, string name)
        {
            double value = 0;
            string stringValue = myAttributes.GetValueByName(name);
            double.TryParse(stringValue, out value);
            return value;
        }

        public static DateTime GetDateTimeValueByName(this IList<Attribute> myAttributes, string name )
        {
            DateTime dateTime;
            string stringValue = myAttributes.GetValueByName(name);
            DateTime.TryParse(stringValue, out dateTime);

            return dateTime;
        }

   }
}
