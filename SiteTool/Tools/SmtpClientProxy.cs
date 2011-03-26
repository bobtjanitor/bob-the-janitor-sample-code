using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Tools
{
    public class SmtpClientProxy : SmtpClient, IEmailClientProxy
    {       
        public new void Send(MailMessage message)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            base.Send(message);
        }

        public new ICredentialsByHost Credentials
        {
            get { return base.Credentials; }
            set { base.Credentials = value; }
        }
    }
}