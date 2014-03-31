using System.Collections.Generic;
using MVVMSampleApp.Core.ServiceInterfaces;

namespace MVVMSampleApp.iOS.ClientServices
{
    public class TouchClientDataService : IDataService
    {
        public List<string> GetDataItems()
        {
            return new List<string> { "Touch Item 1", "Touch Item 2", "Touch Item 3", "Touch Item 4", "Touch Item 5" };
        }
    }
}