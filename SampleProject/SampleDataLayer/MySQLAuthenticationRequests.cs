﻿using System.Data;
using MySql.Data.MySqlClient;

namespace SampleDataLayer
{
    /// <summary>
    /// A Class that implements IAuthenticationRequests 
    /// </summary>
    public class MySQLAuthenticationRequests : IAuthenticationRequests
    {
        /// <summary>
        /// Gets or sets the request interface.
        /// </summary>
        /// <value>The request interface.</value>
        public IMySQLRequests RequestInterface { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySQLAuthenticationRequests"/> class.
        /// </summary>
        public MySQLAuthenticationRequests()
        {
            RequestInterface = new MySQLRequests();
            
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

            MySqlCommand cmd = new MySqlCommand
            {
               CommandType = CommandType.Text,
               CommandText = "Select UserName, Password From User WHERE User.UserName = @UserName"
            };
            cmd.Parameters.AddWithValue("@UserName", userName);
            //Still Refactoring this
            DataTable requestTable = RequestInterface.GetDataTable(cmd, "");
            if (requestTable.Rows.Count>0)
            {
                string UserName = requestTable.Rows[0]["UserName"].ToString();
                string Password = requestTable.Rows[0]["Password"].ToString();
                success = (UserName.Equals(UserName) && Password.Equals(Password));
            }             
            return success;
        }
    }
}
