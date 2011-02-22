using System.Collections.Generic;

namespace Tools
{
    public class Mailer : IMailer
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public IList<string> Errors { get; set; }
        public bool SendMail()
        {
            return false;
        }
    }
}