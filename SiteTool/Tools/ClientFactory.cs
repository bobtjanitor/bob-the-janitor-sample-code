namespace Tools
{
    public static class ClientFactory
    {
        public static IEmailClientProxy GetEmailClient()
        {
            return new SmtpClientProxy();
        }
    }
}