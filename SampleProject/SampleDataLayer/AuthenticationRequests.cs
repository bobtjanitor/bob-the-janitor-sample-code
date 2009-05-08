using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SampleDataLayer
{
    public class AuthenticationRequests :IAuthenticationRequests
    {
        private IDBProviderFactory _userDataProvider = DBUserProviderFactory.Instance;


        public IDBProviderFactory UserDataProvider
        {
            get { return _userDataProvider; }
            set { _userDataProvider = value; }
        }

        public bool AuthenticateUser(string userName, string password)
        {
            bool success = false;
            DataTable requestTable = new DataTable();
            using (IDbConnection conn = UserDataProvider.GetConnection())
            {
                conn.Open();
                IDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select UserName, Password from users where UserName = @Username and Password = @Password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(UserDataProvider.AddParameterWithValue("@UserName",userName));
                cmd.Parameters.Add(UserDataProvider.AddParameterWithValue("@Password", password));
                IDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    requestTable.Load(reader);                    
                }
            }
            if (requestTable.Rows.Count==1 )
            {
                success = true;
            }
            requestTable.Dispose();
            return success;
        }
    }
}
