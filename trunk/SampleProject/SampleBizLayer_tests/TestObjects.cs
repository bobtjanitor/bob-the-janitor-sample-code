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
        /// Gets or sets s Collection of messages for the mock object to fail on.
        /// </summary>
        /// <value>The fail on.</value>
        public Collection<string> FailOn { get; set; }
        private string _currentMessage = string.Empty;
        /// <summary>
        /// The Current Message for What is happening
        /// </summary>
        public string CurrentMessage
        {
            get { return _currentMessage; }
            set 
            {
                _currentMessage = value;
                Messages.Add(value);
            }
        }
      
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestRequest"/> class.
        /// </summary>
        public BaseTestRequest()
        {
            Messages = new Collection<string>();
            FailOn = new Collection<string>();            
        }

        /// <summary>
        /// Was this request successful.
        /// </summary>
        /// <returns></returns>
        public bool WasSuccessful()
        {
            return (!FailOn.Contains(_currentMessage));
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
            CurrentMessage ="AuthenticateUser";
            return WasSuccessful();
        }
    }  
}
