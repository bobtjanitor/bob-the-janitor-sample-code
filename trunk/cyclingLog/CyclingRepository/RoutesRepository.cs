using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class RoutesRepository : IRoutesRepository
    {
        public List<Route> GetUsersRoutes(int userId)
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
                                               Name="Collage of Idaho Loop"
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
        public List<Route> GetUsersRoutes(int userId)
        {
            return stubData;
        }

        public Route GetRouteById(int routeId)
        {
            return (from route in stubData where route.Id == routeId select route).DefaultIfEmpty(new Route()).First();
        }
    }
}
