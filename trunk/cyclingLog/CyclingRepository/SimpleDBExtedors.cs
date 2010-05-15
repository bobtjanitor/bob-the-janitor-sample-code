
using System.Collections.Generic;
using System.Linq;
using Amazon.SimpleDB.Model;

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

   }
}
