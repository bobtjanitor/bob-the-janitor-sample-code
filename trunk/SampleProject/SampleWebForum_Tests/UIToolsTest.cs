using SampleWebForum.UIClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using SampleObjects;

namespace SampleWebForum_Tests
{
    
    
    /// <summary>
    ///This is a test class for UIToolsTest and is intended
    ///to contain all UIToolsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UIToolsTest
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
        ///A test for BuildErrors
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost/SampleWebForum")]
        public void BuildErrorsTest1NoErrors()
        {
            Errors pageErrors = new Errors();
            string expected = "<ul class=\"Error\"></ul>";
            string actual = UITools.BuildErrors(pageErrors);
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod()]
        public void BuildErrorsWith1Error()
        {
            Errors pageErrors = new Errors();
            pageErrors.Add("Test");
            string expected = "<ul class=\"Error\"><li>Test</li></ul>";
            string actual = UITools.BuildErrors(pageErrors);
            Assert.AreEqual(expected, actual);
        }
    }
}
