using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleBizLayer;

namespace SampleBizLayer_tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Authentication_Tests
    {
        private Authentication TestTarget;
        private TestAuthenticationRequests SucessfulAuthenticationRequests;
        private BadTestAuthenticationRequests UnSucessfulAuthenticationRequests;
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
        /// <summary>
        /// initialize the tests in this Test Class.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            TestTarget = new Authentication();
            SucessfulAuthenticationRequests = new TestAuthenticationRequests();
            UnSucessfulAuthenticationRequests = new BadTestAuthenticationRequests();
            TestTarget.AuthenticationRequestInterface = SucessfulAuthenticationRequests;
            
        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Tests the AuthenticateUser method with valid user name and password.
        /// </summary>
        [TestMethod]
        public void AuthenticateUser_Test1()
        {
            string TestUser = "TestUser";
            string TestPass = "TestPass";
            bool Actual = TestTarget.AuthenticateUser(TestUser, TestPass);
            Assert.IsTrue(Actual);
            Assert.IsTrue(SucessfulAuthenticationRequests.Messages[0] == "AuthenticateUser");
        }

        /// <summary>
        /// Tests the AuthenticateUser method with invalid username and valid password.
        /// </summary>
        [TestMethod]
        public void AuthenticateUser_Test2()
        {
            string TestUser = " ";
            string TestPass = "TestPass";
            bool Actual = TestTarget.AuthenticateUser(TestUser, TestPass);
            Assert.IsFalse(Actual);
            Assert.AreEqual(0,SucessfulAuthenticationRequests.Messages.Count);
        }

        /// <summary>
        /// Tests the AuthenticateUser method with valid username and invalid password.
        /// </summary>
        [TestMethod]
        public void AuthenticateUser_Test3()
        {
            string TestUser = "TestUser";
            string TestPass = "";
            bool Actual = TestTarget.AuthenticateUser(TestUser, TestPass);
            Assert.IsFalse(Actual);
            Assert.AreEqual(0, SucessfulAuthenticationRequests.Messages.Count);
        }

        /// <summary>
        /// Tests the AuthenticateUser method with invalid username and password.
        /// </summary>
        [TestMethod]
        public void AuthenticateUser_Test4()
        {
            string TestUser = "";
            string TestPass = "";
            bool Actual = TestTarget.AuthenticateUser(TestUser, TestPass);
            Assert.IsFalse(Actual);
            Assert.AreEqual(0, SucessfulAuthenticationRequests.Messages.Count);
        }

        /// <summary>
        /// Tests the AuthenticateUser method with bad username and password.
        /// </summary>
        [TestMethod]
        public void AuthenticateUser_Test5()
        {
            string TestUser = "TestUser";
            string TestPass = "TestPass";
            TestTarget.AuthenticationRequestInterface = UnSucessfulAuthenticationRequests;
            bool Actual = TestTarget.AuthenticateUser(TestUser, TestPass);
            Assert.IsFalse(Actual);
            Assert.AreEqual(1, UnSucessfulAuthenticationRequests.Messages.Count);
            Assert.IsTrue(UnSucessfulAuthenticationRequests.Messages[0] == "AuthenticateUser");
            Assert.IsTrue(SucessfulAuthenticationRequests.Messages.Count==0);
        }
    }    
}
