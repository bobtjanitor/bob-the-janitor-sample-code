using SampleObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SampleObjects_tests
{        
    /// <summary>
    ///This is a test class for Errors_Tests and is intended
    ///to contain all Errors_Tests Unit Tests
    ///</summary>
    [TestClass()]
    public class Errors_Tests
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
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void Add_Test1_Adding_Empty_Collection()
        {
            Errors target = new Errors();
            Errors newErrors = new Errors();
 
            target.Add(newErrors);
            Assert.AreEqual(target.Count,0);
        }

        [TestMethod()]
        public void Add_Test2_Adding_Non_Empty_Collection()
        {
            Errors target = new Errors();
            Errors newErrors = new Errors {"Test Error"};

            target.Add(newErrors);
            Assert.AreEqual(target.Count, 1);
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void Add_Test1_Adding_string()
        {
            Errors target = new Errors(); 
            string newError = string.Empty; 
            target.Add(newError);
            Assert.AreEqual(target.Count,1);
        }

        [TestMethod()]
        public void Add_Test2_Adding_string()
        {
            Errors target = new Errors();
            string newError = "Test";
            target.Add(newError);
            Assert.AreEqual(target[0].Message, newError);
        }

        /// <summary>
        ///A test for Errors Constructor
        ///</summary>
        [TestMethod()]
        public void ErrorsConstructor_Test()
        {
            Errors target = new Errors();
            Assert.AreEqual(target.Count, 0);
            
        }
    }
}
