using System.Collections.Generic;
using MVVMSampleApp.Droid.ClientServices;
using NUnit.Framework;

namespace MVVMSampleApp.Droid_Tests.DataService_Tests
{
    [TestFixture]
    public class When_Calling_Get_Data_Items_Tests
    {

        public ClientDataService Target;
        public List<string> Actual;
        
        [SetUp]
        public void SetUp()
        {
            Target = new ClientDataService();

            Actual = Target.GetDataItems();
        }

        [Test]
        public void Has_Expected_Number_Of_Items_Test()
        {
            Assert.AreEqual(5,Actual.Count);
        }
    }
}