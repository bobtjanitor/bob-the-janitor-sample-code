using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using MVVMSampleApp.StoreApp.ClientServices;

namespace MVVMSample.StoreApp_Tests.ClientDataService_Tests
{
    [TestClass]
    public class When_Calling_WindowsStoreClientDataService_GetDataItems_Tests
    {
        public WindowsStoreClientDataService Target;
        public List<string> Actual;

        [TestInitialize]
        public void SetUp()
        {
            Target = new WindowsStoreClientDataService();
            Actual = Target.GetDataItems();
        }

        [TestMethod]
        public void Has_Expected_Number_Of_Items_Test()
        {
            Assert.AreEqual(5,Actual.Count);
        }
    }
}
