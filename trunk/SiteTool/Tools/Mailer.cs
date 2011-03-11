﻿using System;
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

        private IEmailClientProxy _mailClient;
        public IEmailClientProxy MailClient
        {
            get
            {
                if (_mailClient==null)
                {
                    _mailClient = ClientFactory.GetEmailClient();
                }
                return _mailClient;
            }
            set { _mailClient = value; }
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
                MailClient.Host = SmtpServer;
                MailClient.EnableSsl = UseSSL;
                if (Port.HasValue)
                {
                    MailClient.Port = Port.Value;
                }
                
                if (!string.IsNullOrEmpty(SmtpUser))
                {
                    MailClient.Credentials = new NetworkCredential(SmtpUser, SmtpPassword);
                }

                MailMessage message = new MailMessage(From, To)
                                          {
                                              Subject = Subject,
                                              Body = Body
                                          };

                MailClient.Send(message);
            }
            catch(Exception mailException)
            {
                Errors.Add(mailException.Message);
                success = false;
            }
            finally
            {
                MailClient.Dispose();
            }
           
            return success;
        }
    }
}