using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace cyclingLog.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RouteService
    {
        [OperationContract]
        public void AddCord(string lat, string lon, string id)
        {
            string value = "";
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
