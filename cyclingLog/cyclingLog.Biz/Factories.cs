using System;
using CyclingRepository;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Biz
{
    public static class Factories
    {
        public static IAuthentiactionRepository GetAuthenticationRepository()
        {
            return new AuthentiactionRepository();
        }

        public static IRoutesRepository GetRoutesRepositoryInterface()
        {
            return new RoutesRepository();
        }

        public static IRouteRepository GetRouteRepository()
        {
            return new RouteRepository();
        }
    }
}