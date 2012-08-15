using System;
using System.Collections.Generic;
using System.Web.Mvc;
using cyclingLog.Factories;
using cyclingLog.Models;
using DomainModels;
using DomainModels.BizInterfaces;
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

        private IRouteRequests _routeRequestsInterface;
        public IRouteRequests RouteRequestsInterface
        {
            get
            {
                if (_routeRequestsInterface==null)
                {
                    _routeRequestsInterface = RouteFactory.GetRouteRequests();
                }
                return _routeRequestsInterface;
            }
            set { _routeRequestsInterface = value; }
        }

        public ActionResult Detail(Guid id)
        {
            RouteModel route = RouteRepositoryInterface.GetRouteById(id).AsRouteModel();
            return View(route);
        }

        public ActionResult RouteList()
        {
            IList<RouteModel> routes = RouteRequestsInterface.GetRoutes().AsRouteModelList();
            return View(routes);
        }

        public ActionResult AddRoute()
        {
            Route newRoute = new Route {Id = Guid.NewGuid()};
            return View("AddUpdateRoute", newRoute);
        }

        public ActionResult UpdateRoute(Route newRoute)
        {
            RouteRequestsInterface.AddRoute(newRoute);
            List<string> errors = RouteRequestsInterface.Errors;
            ViewData["Errors"] = errors;
            if (errors.Count==0)
            {
                ViewData["IsUpdate"] = true;
            }
            return View("AddUpdateRoute",newRoute);
        }

        public ActionResult AddCoordinate(LatLonCoordinate latLonCoordinate )
        {            
            throw new NotImplementedException();
        }
    }
}
