using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class RoutesRepository : IRoutesRepository
    {
        public List<Route> GetUsersRoutes(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Route GetRouteById(int routeId)
        {
            throw new NotImplementedException();
        }
    }

    public class StubRoutesRepository: IRoutesRepository
    {
        List<Route> stubData = new List<Route>()
                                   {
                                       new Route()
                                           {
                                               Id = 1,
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
                                               Id = 2,
                                               Distance = 6.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-14),
                                               Location = "Caldwell, Id",
                                               Name="Park Loop"
                                           },
                                           new Route()
                                           {
                                               Id = 3,
                                               Distance = 8.4,
                                               LastTimeRidden = DateTime.Now.AddDays(-4),
                                               Location = "Caldwell, Id",
                                               Name="Collage of Idaho Loop"
                                           },
                                           new Route()
                                           {
                                               Id = 4,
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

        public Route GetRouteById(int routeId)
        {
            return (from route in stubData where route.Id == routeId select route).DefaultIfEmpty(new Route()).First();
        }
    }
}
