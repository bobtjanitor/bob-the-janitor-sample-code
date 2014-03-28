using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using MVVMSampleApp.WindowsPhone.ClientServices;

namespace MVVMSampleApp.WindowsPhone_Tests.ClientDataService_Tests
{
    [TestClass]
    public class When_Getting_Items_From_Client_Data_Service_Test
    {
        public WindowsPhoneClientDataService Target;
        public List<string> Actual;
        
        [TestInitialize]
        public void Setup()
        {
            Target = new WindowsPhoneClientDataService();
            Actual = Target.GetDataItems();
        }

        [TestMethod]
        public void Has_Expected_Number_Of_Items_Test()
        {
            Assert.AreEqual(5, Actual.Count);
        }
    }
}
