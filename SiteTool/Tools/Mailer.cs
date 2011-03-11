using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Tools
{
    public class Mailer : IMailer
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        private IList<string> _errors = new List<string>();
        public IList<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        private ISmtpClientProxy _smtpClient;
        public ISmtpClientProxy SmtpClient
        {
            get
            {
                if (_smtpClient==null)
                {
                    _smtpClient = new SmtpClientProxy();
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

        public bool UseSSL { get; set; }
        public int? Port { get; set; }

        public bool SendMail()
        {
            bool success = true;
            try
            {
                SmtpClient.Host = SmtpServer;
                SmtpClient.EnableSsl = UseSSL;
                if (Port.HasValue)
                {
                    SmtpClient.Port = Port.Value;
                }
                
                if (!string.IsNullOrEmpty(SmtpUser))
                {
                    SmtpClient.Credentials = new NetworkCredential(SmtpUser, SmtpPassword);
                }

                MailMessage message = new MailMessage(From, To)
                                          {
                                              Subject = Subject,
                                              Body = Body
                                          };

                SmtpClient.Send(message);
            }
            catch(Exception mailException)
            {
                Errors.Add(mailException.Message);
                success = false;
            }
            finally
            {
                SmtpClient.Dispose();
            }
           
            return success;
        }
    }

    public interface ISmtpClientProxy
    {
        void Send(MailMessage message);
        void Dispose();
        string Host { get; set; }
        ICredentialsByHost Credentials { get; set; }
        bool EnableSsl { get; set; }
        int Port { get; set; }
    }

    public class SmtpClientProxy : SmtpClient, ISmtpClientProxy
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