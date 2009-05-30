using SampleDataLayer;

namespace SampleBizLayer
{
    /// <summary>
    /// The biz object that handles Authentication
    /// </summary>
    public class Authentication : IAuthentication
    {
        /// <summary>
        /// Gets or sets the authentication request interface.
        /// </summary>
        /// <value>The authentication request interface.</value>
        public IAuthenticationRequests AuthenticationRequestInterface { get; set; }

        /// <summary>
        /// Gets or sets the request factory interface.
        /// </summary>
        /// <value>The request factory interface.</value>
        public IRequestFactory RequestFactoryInterface { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication"/> class.
        /// </summary>
        public Authentication()
        {
            RequestFactoryInterface = RequestFactory.Instance;
            AuthenticationRequestInterface = RequestFactoryInterface.GetAuthenticationRequests();

        }

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
