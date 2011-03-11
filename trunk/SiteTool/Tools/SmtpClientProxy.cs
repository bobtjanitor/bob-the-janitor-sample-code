using System.Net;
using System.Net.Mail;

namespace Tools
{
    public class SmtpClientProxy : SmtpClient, IEmailClientProxy
    {       
        public new void Send(MailMessage message)
        {
            base.Send(message);
        }

        public new ICredentialsByHost Credentials
        {
            get { return base.Credentials; }
            set { base.Credentials = value; }
        }
    }
}