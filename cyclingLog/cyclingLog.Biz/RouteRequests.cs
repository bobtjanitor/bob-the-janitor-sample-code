using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using DomainModels.BizInterfaces;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Biz
{
    public class RouteRequests : IRouteRequests
    {
        public IRouteRepository RouteRepositoryInterface { get; set; }

        private List<string> _errors = new List<string>();
        public List<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        public bool AddRoute(Route route)
        {
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
