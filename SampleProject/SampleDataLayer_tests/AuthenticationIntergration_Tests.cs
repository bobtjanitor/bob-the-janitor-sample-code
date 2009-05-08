using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using SampleDataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleDataLayer_tests
{
    /// <summary>
    /// Summary description for AuthenticationIntergration_Tests
    /// </summary>
    [TestClass]
    public class AuthenticationIntergration_Tests
    {     
     
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AuthenticateUser_TestForValidUserNameAndPassword()
        {
            string userName = "Bob";
            string password = "123456";
            bool expected = true;
            AuthenticationRequests authenticationRequests = new AuthenticationRequests();
            bool acual = authenticationRequests.AuthenticateUser(userName, password);
            Assert.AreEqual(expected,acual);
           
        }
    }
}
