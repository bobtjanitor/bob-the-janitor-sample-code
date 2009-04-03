using System.Collections.ObjectModel;
using SampleDataLayer;

namespace SampleBizLayer_tests
{
    /// <summary>
    /// Base class all of the Mock request objects implement that covers all of the common 
    /// functionality.
    /// </summary>
    public class BaseTestRequest
    {
        /// <summary>
        /// Gets or sets the messages set by the methods called in classes that inherit this class.
        /// </summary>
        /// <value>The messages.</value>
        public Collection<string> Messages { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestRequest"/> class.
        /// </summary>
        public BaseTestRequest()
        {
            Messages = new Collection<string>();
        }
    }

    /// <summary>
    /// A Mock Authentication object that implements IAuthenticationRequests
    /// this is used to test functionality of Authentication Requests that are correct
    /// </summary>
    public class TestAuthenticationRequests : BaseTestRequest, IAuthenticationRequests
    {
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>true</returns>
        public bool AuthenticateUser(string userName, string password)
        {
            Messages.Add("AuthenticateUser");
            return true;
        }
    }

    /// <summary>
    /// A Mock Authentication object that implements IAuthenticationRequests
    /// this is used to test functionality of Authentication Requests that are incorrect
    /// </summary>
    public class BadTestAuthenticationRequests : BaseTestRequest, IAuthenticationRequests
    {
        /// <summary>
        /// Dosn't Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>false</returns>
        public bool AuthenticateUser(string userName, string password)
        {
            Messages.Add("AuthenticateUser");
            return false;
        }
    }
}
