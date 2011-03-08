using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;

namespace Tools
{
    public class Mailer : IMailer
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public IList<string> Errors { get; set; }

        private SmtpClient _smtpClient;
        public SmtpClient SmtpClient
        {
            get
            {
                if (_smtpClient==null)
                {
                    _smtpClient = new SmtpClient();
                }
                return _smtpClient;
            }
            set { _smtpClient = value; }
        }

        private string _smtpServer;
        public string SmtpServer
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_smtpServer))
                {
                    _smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
                }
                return _smtpServer;
            }
            set { _smtpServer = value; }
        }

        private string _smtpUser;
        public string SmtpUser
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_smtpUser))
                {
                    _smtpUser = ConfigurationManager.AppSettings["SmtpUser"];
                }
                return _smtpUser;
            }
            set { _smtpUser = value; }
        }

        private string _smtpPassword;
        public string SmtpPassword
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_smtpPassword))
                {
                    _smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
                }
                return _smtpPassword;
            }
            set { _smtpPassword = value; }
        }

        public bool SendMail()
        {
            
            return false;
        }
    }
}