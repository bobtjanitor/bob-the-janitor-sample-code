using System.Collections.Generic;
using MVVMSampleApp.Core.ServiceInterfaces;

namespace MVVMSampleApp.Droid.ClientServices
{
    public class ClientDataService : IDataService
    {
        public List<string> GetDataItems()
        {
            return new List<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
        }
    }
}