using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DomainModels;

namespace cyclingLog.Models
{
    public class ProfileModel : Profile
    {       
        public List<RouteModel> RouteList { get; set; }
    }

    public class RouteModel : Route
    {
    }
}