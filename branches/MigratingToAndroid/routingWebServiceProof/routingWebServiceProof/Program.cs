using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using routingWebServiceProof.RoutingWebService;

namespace routingWebServiceProof
{
    class Program
    {
        static void Main(string[] args)
        {
            RoutingServiceClient client = new RoutingServiceClient();
            RouteRequest request = new RouteRequest();
            request.UserName = "TestUser";
            request.Password = "tupass123";
            request.IntegrationId = 4;
            request.MilesPerGallon = 6;
            request.Locations = new RouteLocation[]
                                    {
                                        new RouteLocation(){City = "Boise",State = "ID"}, 
                                        new RouteLocation(){City = "Denver",State = "Co"},
                                    };

            RouteReturn returnValue = client.GetRoute(request);

            foreach (Error error in returnValue.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
            Console.WriteLine(returnValue.AverageFuelPrice);
            Console.WriteLine(returnValue.CostPerMile); 
            Console.WriteLine(returnValue.EstimatedFuelCost);
            Console.ReadKey();
        }
    }
}
