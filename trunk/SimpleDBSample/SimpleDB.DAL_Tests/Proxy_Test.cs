using System.Collections.Generic;
using SimpleDB.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDB.Objects;
using Amazon.SimpleDB;

namespace SimpleDB.DAL_Tests
{   
    /// <summary>
    ///This is a test class for ContactProxy_Test and is intended
    ///to contain all ContactProxy_Test Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactProxy_Tests
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

        
        [TestMethod()]
        public void AddDomain_DeleteDomain_Test()
        {
            Proxy target = new Proxy();
            string TestDomainName = "TestDomain";
            List<string> StartingDomainList = target.GetDomains();
            Assert.IsFalse(StartingDomainList.Contains(TestDomainName));

            target.AddDomain(TestDomainName);
            List<string> AddedDomainList = target.GetDomains();
            Assert.IsTrue(AddedDomainList.Contains(TestDomainName));

            target.DeleteDomain(TestDomainName);
            List<string> DeletedDomainList = target.GetDomains();
            Assert.IsFalse(DeletedDomainList.Contains(TestDomainName));
        }
    }
}
