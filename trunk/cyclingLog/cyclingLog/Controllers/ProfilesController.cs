using System;
using System.Collections.Generic;
using System.Web.Mvc;
using cyclingLog.Factories;
using cyclingLog.Models;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Controllers
{
    public class ProfilesController : Controller
    {
        private IProfilesRepository _profilesRepository;
        public IProfilesRepository ProfilesRepository
        {
            get
            {
                if (_profilesRepository==null)
                {
                    _profilesRepository = RepositoryFactory.GetProfilesRepository();
                }
                return _profilesRepository;
            }
            set { _profilesRepository = value; }
        }

        private IRoutesRepository _routesRepository;

        public IRoutesRepository RoutesRepository
        {
            get
            {
                if (_routesRepository == null)
                {
                    _routesRepository = RepositoryFactory.GetRoutesRepository();
                }
                return _routesRepository;
            }
            set { _routesRepository = value; }
        }

        //
        // GET: /Profiles/

        public ActionResult Index()
        {
            ViewData["AuthUserGuid"] = Request.ServerVariables.Get("AUTH_USER");
            List<ProfileModel> list = ProfilesRepository.GetProfileList().AsProfileModelList();
            return View(list);
        }

        public ActionResult Detail(Guid id)
        {
            ViewData["AuthUserGuid"] = Request.ServerVariables.Get("AUTH_USER");
            ProfileModel profile = ProfilesRepository.GetProfileById(id).AsProfileModel();
            profile.RouteList = RoutesRepository.GetUsersRoutes(id).AsRouteModelList();
            return View(profile);
        }

    }
}
