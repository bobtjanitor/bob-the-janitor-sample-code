using SampleObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SampleObjects_tests
{
    /// <summary>
    ///This is a test class for Error_Tests and is intended
    ///to contain all Error_Tests Unit Tests
    ///</summary>
    [TestClass()]
    public class Error_Tests
    {     
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Message
        ///</summary>
        [TestMethod()]
        public void Message_Test1_Empty_Message()
        {
            string error = string.Empty; 
            Error target = new Error(error);
            string expected = string.Empty;
            target.Message = expected;
            string actual = target.Message;
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod()]
        public void Message_Test2_Message_Content()
        {
            string error = "Test String";
            Error target = new Error(error);
            string expected = string.Empty;
            target.Message = expected;
            string actual = target.Message;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Error Constructor
        ///</summary>
        [TestMethod()]
        public void ErrorConstructor_Test1_Empty_error()
        {
            string error = string.Empty; 
            Error target = new Error(error);

            Assert.AreEqual(target.Message, error);
        }

        [TestMethod()]
        public void ErrorConstructor_Test2_non_Empty_error()
        {
            string error = "Test string";
            Error target = new Error(error);

            Assert.AreEqual(target.Message, error);
        }
    }
}
