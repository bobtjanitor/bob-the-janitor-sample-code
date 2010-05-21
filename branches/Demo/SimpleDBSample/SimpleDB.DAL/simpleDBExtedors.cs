using System.Collections.Generic;
using System.Linq;
using Amazon.SimpleDB.Model;

namespace SimpleDB.DAL
{
    public static class SimpleDBExtedors
    {
        public static string GetValueByName(this IList<Attribute> myAttributes, string name)
        {
            string myValue = (from attribute in myAttributes where attribute.Name == name select attribute.Value).FirstOrDefault();
            string value = string.Empty;
            if (!string.IsNullOrEmpty(myValue))
            {
                value = myValue; 
            }

            return value;
        }
    }
}