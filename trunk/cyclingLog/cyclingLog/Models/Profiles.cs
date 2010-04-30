using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DomainModels;

namespace cyclingLog.Models
{
    public class ProfileModel : Profile
    {
        private List<RouteModel> _routeList=new List<RouteModel>();
        public List<RouteModel> RouteList
        {
            get { return _routeList; }
            set { _routeList = value; }
        }
    }

    public class RouteModel : Route
    {
    }
}