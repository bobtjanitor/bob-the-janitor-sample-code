using System.Data;

namespace SampleDataLayer
{
    /// <summary>
    /// A class the implements the <see cref="IAuthenticationRequests"/> interface and uses a 
    /// Provider Factory to make authentication requests against any type of database specified in
    /// your config file (web.config, app.config, machine.config, etc)
    /// </summary>
    public class AuthenticationRequests :IAuthenticationRequests
    {
        private IDBProviderFactory _userDataProvider = DBUserProviderFactory.Instance;


        /// <summary>
        /// Gets or sets the user data provider mostly this is for testing.
        /// </summary>
        /// <value>The user data provider.</value>
        public IDBProviderFactory UserDataProvider
        {
            get { return _userDataProvider; }
            set { _userDataProvider = value; }
        }

        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool AuthenticateUser(string userName, string password)
        {
            bool success = false;
            DataTable requestTable = new DataTable();
            using (IDbConnection conn = UserDataProvider.GetAuthenticationConnection())
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
