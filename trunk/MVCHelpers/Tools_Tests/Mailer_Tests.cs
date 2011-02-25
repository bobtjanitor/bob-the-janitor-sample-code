using System.Configuration;
using Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tools_Tests
{
    [TestClass()]
    public class Mailer_Tests
    {
        private Mailer target; 

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new Mailer(); 
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

        /// <summary>
        ///A test for Subject
        ///</summary>
        [TestMethod()]
        public void Subject_Test()
        {
            Mailer target = new Mailer(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Subject = expected;
            actual = target.Subject;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for To
        ///</summary>
        [TestMethod()]
        public void To_Test()
        {
            Mailer target = new Mailer(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.To = expected;
            actual = target.To;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }


        ///// <summary>
        /////A test for SendMail
        /////</summary>
        //[TestMethod()]
        //public void SendMail_Test()
        //{
        //    bool expected = false; // TODO: Initialize to an appropriate value
        //    bool actual;
        //    actual = target.SendMail();
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
