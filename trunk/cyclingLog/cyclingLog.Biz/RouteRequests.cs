using System;
using System.Collections.Generic;
using DomainModels;
using DomainModels.BizInterfaces;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Biz
{
    public class RouteRequests : IRouteRequests
    {
        private IRouteRepository _routeRepositoryInterface;
        public IRouteRepository RouteRepositoryInterface
        {
            get
            {
                if (_routeRepositoryInterface==null)
                {
                    _routeRepositoryInterface = Factories.GetRouteRepository();
                }
                return _routeRepositoryInterface;
            }
            set { _routeRepositoryInterface = value; }
        }

        private IRoutesRepository _routesRepositoryInterface;
        public IRoutesRepository RoutesRepositoryInterface
        {
            get
            {
                if (_routesRepositoryInterface==null)
                {
                    _routesRepositoryInterface = Factories.GetRoutesRepositoryInterface();
                }
                return _routesRepositoryInterface;
            }
            set { _routesRepositoryInterface = value; }
        }

        private List<string> _errors = new List<string>();
        public List<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        public Route GetRouteById(Guid id)
        {
            Errors.Clear();
            Route route = new Route();
            if (id == new Guid())
            {
                Errors.Add("Invalid route Id");
            }
            else
            {
                route = RoutesRepositoryInterface.GetRouteById(id);
            }
            return route;

        }
            
        public bool AddRoute(Route route)
        {
            Errors.Clear();
            if (string.IsNullOrWhiteSpace(route.Name))
            {
                Errors.Add("Name is required");
            }

            if (string.IsNullOrWhiteSpace(route.Location))
            {
                Errors.Add("Location is required");
            }

            if (route.Id == new Guid())
            {
                Errors.Add("Invalid route Id");
            }

            if (Errors.Count==0)
            {
                if (!RouteRepositoryInterface.AddUpdateRoute(route))
                {
                    Errors.Add("An error occured saving this route.");
                }
            }

            return Errors.Count == 0;
        }
    }
}
