using SampleDataLayer;

namespace SampleBizLayer
{
    /// <summary>
    /// The biz object that handles Authentication
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// Gets or sets the authentication request interface.
        /// </summary>
        /// <value>The authentication request interface.</value>
        public IAuthenticationRequests AuthenticationRequestInterface { get; set; }

        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
        /// <returns></returns>
        public bool AuthenticateUser(string user, string pass)
        {
            bool success = false;
            if (user.Trim().Length>0 && pass.Trim().Length>0)
            {
                success = AuthenticationRequestInterface.AuthenticateUser(user, pass);                
            }
            return success;
        }        
    }
}
