namespace SampleBizLayer
{
    public interface IAuthentication
    {
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
        /// <returns></returns>
        bool AuthenticateUser(string user, string pass);
    }
}