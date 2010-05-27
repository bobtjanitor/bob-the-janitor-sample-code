using System;
using System.Collections.Generic;
using System.Web.Mvc;
using cyclingLog.Factories;
using cyclingLog.Models;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Controllers
{
    public class RouteController : Controller
    {
        private IRoutesRepository _routeRepositoryInterface;
        public IRoutesRepository RouteRepositoryInterface
        {
            get
            {
                if (_routeRepositoryInterface==null)
                {
                    _routeRepositoryInterface = RepositoryFactory.GetRoutesRepository();
                }
                return _routeRepositoryInterface;
            }
            set { _routeRepositoryInterface = value; }
        }

        public ActionResult Detail(Guid id)
        {
            RouteModel route = RouteRepositoryInterface.GetRouteById(id).AsRouteModel();
            return View(route);
        }

        public ActionResult AddRoute()
        {
            Route newRoute = new Route {Id = Guid.NewGuid()};
            return View(newRoute);
        }

        public ActionResult AddRoute(Route newRoute)
        {
            List<string> errors =  
            return View(newRoute);
        }
    }
}
