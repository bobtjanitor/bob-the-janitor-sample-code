using System.Collections.Generic;
using System.Linq;
using cyclingLog.Models;
using DomainModels;

namespace cyclingLog
{
    public static class Extenders
    {
        public static List<ProfileModel> AsProfileModelList(this Profiles profiles)
        {
            return profiles.Select(profile => profile.AsProfileModel()).ToList();
        }

        public static ProfileModel AsProfileModel(this Profile profile)
        {
            ProfileModel item = new ProfileModel
            {
                Description = profile.Description,
                Id = profile.Id,
                Name = profile.Name,
                Location = profile.Location
            };
            return item;
        }

        public static RouteModel AsRouteModel(this Route route)
        {
            RouteModel routeModel = new RouteModel
                                        {
                                            Distance = route.Distance,
                                            LastTimeRidden = route.LastTimeRidden,
                                            Id = route.Id,
                                            Location = route.Location,
                                            Name = route.Name,
                                            RouteCoordinates = route.RouteCoordinates
                                        };
            return routeModel;
        }

        public static List<RouteModel> AsRouteModelList(this IList<Route> list)
        {
            var modelList = from item in list
                            select new RouteModel()
                                       {
                                           Distance = item.Distance,
                                           Id = item.Id,
                                           LastTimeRidden = item.LastTimeRidden,
                                           Location = item.Location,
                                           Name = item.Name
                                       };
            return modelList.ToList();
        }
    }
}