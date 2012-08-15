using System.Collections.Generic;

namespace Tools
{
    public interface IMailer
    {
        string Subject { get; set; }
        string To { get; set; }
        string From { get; set; }
        string Body { get; set; }
        IList<string> Errors { get; set; }
        string SmtpServer { get; set; }
        string SmtpUser { get; set; }
        bool? UseSSL { get; set; }
        int? Port { get; set; }
        bool SendMail();
    }
}
