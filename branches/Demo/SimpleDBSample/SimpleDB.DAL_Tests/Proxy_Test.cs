using System.Collections.Generic;
using SimpleDB.DAL;
using NUnit.Framework;
using SimpleDB.Objects;
using Amazon.SimpleDB;

namespace SimpleDB.DAL_Tests
{   
    /// <summary>
    ///This is a test class for ContactProxy_Test and is intended
    ///to contain all ContactProxy_Test Unit Tests
    ///</summary>
    [TestFixture()]
    public class ContactProxy_Tests
    {
       
        [Test()]
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
