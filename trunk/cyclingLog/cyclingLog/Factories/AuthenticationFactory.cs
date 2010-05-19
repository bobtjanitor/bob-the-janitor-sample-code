using cyclingLog.Biz;

namespace cyclingLog.Factories
{
    public static class AuthenticationFactory
    {
        public static IAuthentication GetAuthentication()
        {
            return new Authentication();
        }
    }
}