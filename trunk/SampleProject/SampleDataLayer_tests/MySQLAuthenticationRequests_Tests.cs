using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleDataLayer;

namespace SampleDataLayer_tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private MySQLAuthenticationRequests TestTarget = new MySQLAuthenticationRequests();
        private TestMySqlRequestInterface TestInterface;
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
         /// Initialize test Mehtod data.
         /// </summary>
         [TestInitialize()]
         public void MyTestInitialize()
         {
             TestInterface = new TestMySqlRequestInterface();
             TestTarget.RequestInterface = TestInterface;                          
         }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion   
         /// <summary>
         /// A test that Authenticates the user with a good user name and password.
         /// </summary>
        [TestMethod]
        public void AuthenticateUser_TestWithGoodUserNameAndPassword()
        {
             string UserName = "TestUser";
             string Password = "TestPass";
             TestInterface.TestReturnData.Add("UserName", UserName);
             TestInterface.TestReturnData.Add("Password", Password);
             bool Result = TestTarget.AuthenticateUser(UserName, Password);
             Assert.AreEqual(true, Result);           
        }

    }
}
