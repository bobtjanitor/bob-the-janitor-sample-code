using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Moq;
using Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tools_Tests
{
    [TestClass()]
    public class Mailer_Tests
    {
        private Mailer target;
        private Mock<IEmailClientProxy> SmtpClientContext;

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new Mailer()
                         {
                             SmtpServer = "Invalid", 
                             SmtpUser = string.Empty, 
                             SmtpPassword = "Invalid",
                             From = "Invalid@invalid.com",
                             To = "Invalid@invalid.com", 
                         };
            SmtpClientContext = new Mock<IEmailClientProxy>();
            SmtpClientContext.SetupAllProperties();
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Verifiable("called send");
            target.MailClient = SmtpClientContext.Object;
        }

        /// <summary>
        ///A test for Body
        ///</summary>
        [TestMethod()]
        public void Body_returnsSetValue_Test()
        {
            string expected = "Test body";
            target.Body = expected;
            string actual = target.Body;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Errors
        ///</summary>
        [TestMethod()]
        public void Errors_returnsSetValue_Test()
        {
            IList<string> expected = new List<string>(){"test value 1", "test value 2"};
            target.Errors = expected;
            IList<string> actual = target.Errors;
            Assert.AreEqual(expected[1], actual[1]);
        }

        /// <summary>
        ///A test for From
        ///</summary>
        [TestMethod()]
        public void From_returnsSetValue_Test()
        {
            string expected = "Test From";
            target.From = expected;
            string actual = target.From;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SmtpPassword
        ///</summary>
        [TestMethod()]
        public void SmtpPassword_returnsSetValue_Test()
        {
            ConfigurationManager.AppSettings["SmtpPassword"] = "not the value I'm Looking For";
            string expected = "Test password";
            target.SmtpPassword = expected;
            string actual = target.SmtpPassword;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SmtpPassword_returnsAppSettingWhenNotSet_Test()
        {
            string expected = "The value I'm Looking For";
            ConfigurationManager.AppSettings["SmtpPassword"] = expected;
            target.SmtpPassword = string.Empty;
            string actual = target.SmtpPassword;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SmtpServer_returnsSetValue_Test()
        {
            string expected = "Test Server";
            target.SmtpServer = expected;
            string actual = target.SmtpServer;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SmtpServer_returnsAppSettingWhenNotSet_Test()
        {
            string expected = "Test Server";
            ConfigurationManager.AppSettings["SmtpServer"] = expected;
            target.SmtpServer = string.Empty;
            string actual = target.SmtpServer;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SmtpUser
        ///</summary>
        [TestMethod()]
        public void SmtpUser_returnsSetValue_Test()
        {
            string expected = "Test User";
            target.SmtpUser = expected;
            string actual = target.SmtpUser;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SmtpUser_ReturnsAppSettingWhenNotSet_Test()
        {
            string expected = "Test Server";
            ConfigurationManager.AppSettings["SmtpUser"] = expected;
            target.SmtpUser = string.Empty;
            string actual = target.SmtpUser;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Subject
        ///</summary>
        [TestMethod()]
        public void Subject_returnsSetValue_Test()
        {
            string expected = "test Subject"; 
            target.Subject = expected;
            string actual = target.Subject;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for To
        ///</summary>
        [TestMethod()]
        public void To_ReturnsSetValue_Test()
        {
            string expected = "test@test.com"; 
            target.To = expected;
            string actual = target.To;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void SendMail_SetsSmtpServer_Test()
        {
            string expected = "Test Server";
            target.SmtpServer = expected;
            target.SendMail();
            Assert.AreEqual(expected, target.MailClient.Host);
        }

        [TestMethod()]
        public void SendMail_SetsSmtpUserIfHasUser_Test()
        {
            string expected = "Test User";
            target.SmtpUser = expected;
            target.SendMail();
            Assert.AreEqual(expected, ((NetworkCredential)target.MailClient.Credentials).UserName);
        }
        [TestMethod()]
        public void SendMail_SetsSmtpPasswordIfHasUser_Test()
        {
            string expected = "Test User";
            target.SmtpUser = "something";
            target.SmtpPassword = expected;
            target.SendMail();
            Assert.AreEqual(expected, ((NetworkCredential)target.MailClient.Credentials).Password);
        }

        [TestMethod()]
        public void SendMail_HasNoCredintialsIfHasNoUser_Test()
        {
            target.SendMail();
            Assert.IsNull(target.MailClient.Credentials);
        }

        [TestMethod()]
        public void SendMail_SetsSubject_Test()
        {
            MailMessage testMessage = new MailMessage();
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Callback<MailMessage>(c => testMessage = c);
            string expected = "Test Subject";
            target.Subject = expected;
            target.SendMail();
            Assert.AreEqual(expected, testMessage.Subject);
        }

        [TestMethod()]
        public void SendMail_SetsTo_Test()
        {
            MailMessage testMessage = new MailMessage();
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Callback<MailMessage>(c => testMessage = c);
            string expected = "Test@Test.com";
            target.To = expected;
            target.SendMail();
            Assert.AreEqual(expected, testMessage.To.First().Address);
        }

        [TestMethod()]
        public void SendMail_SetsFrom_Test()
        {
            MailMessage testMessage = new MailMessage();
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Callback<MailMessage>(c => testMessage = c);
            string expected = "Test@Test.com";
            target.From = expected;
            target.SendMail();
            Assert.AreEqual(expected, testMessage.From.Address);
        }

        [TestMethod()]
        public void SendMail_SetsBody_Test()
        {
            MailMessage testMessage = new MailMessage();
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Callback<MailMessage>(c => testMessage = c);
            string expected = "Test@Test.com";
            target.Body = expected;
            target.SendMail();
            Assert.AreEqual(expected, testMessage.Body);
        }

        [TestMethod()]
        public void SendMail_ReturnsErrorForFailedSend_Test()
        {
            string expected = "Test@Test.com";
            SmtpClientContext.Setup(x => x.Send(It.IsAny<MailMessage>())).Throws(new Exception(expected));
            target.SendMail();
            Assert.AreEqual(expected, target.Errors.First());
        }

    }

    [TestClass]
    public class Mailer_Intergration_Tests
    {
        private Mailer target;

        [TestInitialize]
        public void Setup()
        {
            target = new Mailer();
            //target.SmtpServer = "smtp.server.com";
        }

        [TestMethod]
        public void SendMail_SendsAnEmail_Intergration_Test()
        {
            target.Subject = "Test message";
            target.To = "bobtjanitor@gmail.com";
            target.From = "bobtjanitor@gmail.com";
            target.Body = "test body";
            //custom port for the smtp server I'm using
            target.Port = 587;
            target.UseSSL = true;
            bool actual = target.SendMail();
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SendMail_SendsAnEmailWithOutErrors_Intergration_Test()
        {
            target.Subject = "Test message";
            target.To = "bobtjanitor@gmail.com";
            target.From = "bobtjanitor@gmail.com";
            target.Body = "test body";
            //custom port for the smtp server I'm using
            target.Port = 587;
            target.UseSSL = true;
            target.SendMail();
            Assert.AreEqual(0,target.Errors.Count);
        }

        [TestMethod]
        public void SendMail_HandleErrors_Intergration_Test()
        {
            target.Subject = "Test message";
            target.To = "bobtjanitor@gmail.com";
            target.From = "bobtjanitor@gmail.com";
            target.Body = "test body";
            //custom port for the smtp server I'm using
            target.Port = 587;
            target.UseSSL = false;
            target.SendMail();
            Assert.AreEqual(0, target.Errors.Count);
        }
    }
}
