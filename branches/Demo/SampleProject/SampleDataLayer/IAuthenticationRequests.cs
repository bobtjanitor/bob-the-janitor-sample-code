namespace SampleDataLayer
{
    /// <summary>
    /// The interface for handling Authentication Requests
    /// </summary>
    public interface IAuthenticationRequests
    {
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool AuthenticateUser(string userName, string password);
    }
}