using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class RoutesRepository : SimpleDBRepositoryBase, IRoutesRepository
    {
        public List<Route> GetUsersRoutes(Guid userId)
        {
            List<Route> list = new List<Route>();
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request =
                    new SelectRequest().WithSelectExpression(
                        string.Format("SELECT RouteId FROM ProfileRoutes where ProfileId = '{0}'", userId));
                SelectResponse response = client.Select(request);
                foreach (Item routeItem in response.SelectResult.Item)
                {
                    list.Add(new Route() { Id =Guid.Parse(routeItem.Attribute.GetValueByName("RouteId")) });
                    
                }
            }

            return list;
        }

        public Route GetRouteById(Guid routeId)
        {
            Route route = new Route();
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request =
                    new SelectRequest().WithSelectExpression(
                        string.Format("SELECT * FROM Routes where Id = '{0}'", routeId));
                SelectResponse response = client.Select(request);

                if (response.SelectResult.Item.Count>0)
                {
                    route.Id = Guid.Parse(response.SelectResult.Item[0].Attribute.GetValueByName("Id"));
                    route.Distance = response.SelectResult.Item[0].Attribute.GetDoubleValueByName("Distance");
                    route.LastTimeRidden = response.SelectResult.Item[0].Attribute.GetDateTimeValueByName("LastTimeRidden");
                }
                
            }
            return route;

        }

        public Routes GetAllRoutes()
        {
            Routes routes = new Routes();
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request =
                   new SelectRequest().WithSelectExpression(
                       string.Format("SELECT * FROM Routes "));
                SelectResponse response = client.Select(request);
                foreach (Item item in response.SelectResult.Item)
                {
                    string value = item.Attribute.GetValueByName("Id");
                    Route route = new Route
                    {

                        Id = Guid.Parse(item.Attribute.GetValueByName("Id")),
                        Distance = item.Attribute.GetDoubleValueByName("Distance"),
                        LastTimeRidden = item.Attribute.GetDateTimeValueByName("LastTimeRidden"),
                        Name = item.Attribute.GetValueByName("Name"),
                        Location = item.Attribute.GetValueByName("Location"),
                    };
                    routes.Add(route);
                }
            }
            return routes;
        }
    }

    public class StubRoutesRepository: IRoutesRepository
    {
        List<Route> stubData = new List<Route>()
                                   {
                                       new Route()
                                           {
                                               Id = new Guid("6fa89d9e-b230-44c3-ad34-2f7bc1ef736c"),
                                               Distance = 8.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-4),
                                               Location = "Caldwell, Id",
                                               Name="Collage of Idaho Loop",
                                               RouteCoordinates = new List<LatLonCoordinate>()
                                                  {
                                                      new LatLonCoordinate()
                                                          {
                                                              Lat = 43.62027442738427,
                                                              Lon = -116.65758691728115
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.627627,
                                                              Lon = -116.667486
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.62747676670551,
                                                              Lon = -116.66454523801804
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.627808690071106,
                                                              Lon = -116.6630083322525
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.61903250217438,
                                                              Lon = -116.66299760341644
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.61891984939575,
                                                              Lon = -116.67299151420593
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.65262247622013,
                                                              Lon = -116.67316854000092
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                              Lat = 43.646069169044495,
                                                              Lon = -116.6629010438919
                                                          },
                                                          new LatLonCoordinate()
                                                          {
                                                             Lat = 43.62743854522705,
                                                             Lon = -116.66747152805328
                                                          }
                                                  }                                                  
                                           },
                                           new Route()
                                           {
                                               Id = new Guid("6fa89d9e-b230-44c3-ad34-2f7bc1ef7361"),
                                               Distance = 6.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-14),
                                               Location = "Caldwell, Id",
                                               Name="Park Loop"
                                           },
                                           new Route()
                                           {
                                               Id = new Guid("6fa89d9e-b230-44c3-ad34-2f7bc1ef7363"),
                                               Distance = 8.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-4),
                                               Location = "Caldwell, Id",
                                               Name="Collage of Idaho Loop"
                                           },
                                           new Route()
                                           {
                                               Id = new Guid("6fa89d9e-b230-44c3-ad34-2f7bc1ef733c"),
                                               Distance = 6.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-14),
                                               Location = "Caldwell, Id",
                                               Name="Park Loop"
                                           }
                                   };
        public List<Route> GetUsersRoutes(Guid userId)
        {
            return stubData;
        }

        public Route GetRouteById(Guid routeId)
        {
            return (from route in stubData where route.Id == routeId select route).DefaultIfEmpty(new Route()).First();
        }

        public Routes GetAllRoutes()
        {
            Routes routes = new Routes();
            foreach (Route route in stubData)
            {
                routes.Add(route);
            }
            return routes;
        }
    }
}
