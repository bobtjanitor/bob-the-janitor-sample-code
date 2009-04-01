using System;

namespace SampleDataLayer
{
    /// <summary>
    /// A Class that implements IAuthenticationRequests 
    /// </summary>
    public class AuthenticationRequests : IAuthenticationRequests
    {
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool AuthenticateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
