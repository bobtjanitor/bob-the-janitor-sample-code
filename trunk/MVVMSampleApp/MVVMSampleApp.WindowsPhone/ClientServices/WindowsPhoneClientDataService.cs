using System.Collections.Generic;
using MVVMSampleApp.Core.ServiceInterfaces;

namespace MVVMSampleApp.WindowsPhone.ClientServices
{
    public class WindowsPhoneClientDataService : IDataService
    {
        public List<string> GetDataItems()
        {
            return new List<string> { "Phone Item 1", "Phone Item 2", "Phone Item 3", "Phone Item 4", "Phone Item 5" };
        }
    }
}
