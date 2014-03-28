using System.Collections.Generic;
using MVVMSampleApp.Core.ServiceInterfaces;

namespace MVVMSampleApp.StoreApp.ClientServices
{
    public class WindowsStoreClientDataService : IDataService
    {
        public List<string> GetDataItems()
        {
            return new List<string> { "RT Item 1", "RT Item 2", "RT Item 3", "RT Item 4", "RT Item 5" };
        }
    }
}
