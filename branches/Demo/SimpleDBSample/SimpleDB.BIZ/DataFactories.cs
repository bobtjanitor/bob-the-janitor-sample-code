using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleDB.Objects;
using SimpleDB.DAL;

namespace SimpleDB.BIZ
{
        public static class DataFactories
        {
            public static IContactData GetContactInterface()
            {
                IContactData myContactData = myContactData= new  ContactData();
                
                return myContactData;
            }
        }
}
