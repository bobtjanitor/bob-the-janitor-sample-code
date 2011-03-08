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
        bool SendMail();
    }
}
