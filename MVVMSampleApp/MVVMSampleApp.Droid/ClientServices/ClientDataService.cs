using System.Collections.Generic;
using MVVMSampleApp.Core.ServiceInterfaces;

namespace MVVMSampleApp.Droid.ClientServices
{
    public class DroidClientDataService : IDataService
    {
        public List<string> GetDataItems()
        {
            return new List<string> { "Droid Item 1", "Droid Item 2", "Droid Item 3", "Droid Item 4", "Droid Item 5" };
        }
    }
}