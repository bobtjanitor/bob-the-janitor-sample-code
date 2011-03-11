using Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tools_Tests
{
    [TestClass()]
    public class ClientFactory_Tests
    {
        [TestMethod()]
        public void GetEmailClient_ReturnExpectedType_Test()
        {
            IEmailClientProxy actual = ClientFactory.GetEmailClient();
            Assert.IsInstanceOfType(actual, typeof(SmtpClientProxy));
        }
    }
}
