using System.Net;
using System.Net.Mail;

namespace Tools
{
    public interface IEmailClientProxy
    {
        void Send(MailMessage message);
        void Dispose();
        string Host { get; set; }
        ICredentialsByHost Credentials { get; set; }
        bool EnableSsl { get; set; }
        int Port { get; set; }
    }
}