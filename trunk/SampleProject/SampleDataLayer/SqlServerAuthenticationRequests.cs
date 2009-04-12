using System;
using System.Data.Linq;
using System.Linq;

namespace SampleDataLayer
{
    class SqlServerAuthenticationRequests : IAuthenticationRequests
    {
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool AuthenticateUser(string userName, string password)
        {
            bool success;
            using (CustomersDataContext db = new CustomersDataContext())
            {
                var user = from c in db.Customers 
                           where c.User_Name == userName && c.Password == password
                           select c;
                success = (user.Count() > 0);
            }
            return success;
        }
    }
}
