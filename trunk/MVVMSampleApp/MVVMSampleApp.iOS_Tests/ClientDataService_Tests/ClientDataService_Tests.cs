using System.Collections.Generic;
using MVVMSampleApp.iOS.ClientServices;
using NUnit.Framework;

namespace MVVMSampleApp.iOS_Tests.ClientDataService_Tests
{
    [TestFixture]
    public class ClientDataService_Tests
    {
        public TouchClientDataService Target;
        public List<string> Actual;

        [SetUp]
        public void SetUp()
        {
            Target = new TouchClientDataService();
            Actual = Target.GetDataItems();
        }

        [Test]
        public void Has_Expected_Number_Of_Items_Test()
        {
            Assert.AreEqual(5,Actual.Count);
        }

    }
}