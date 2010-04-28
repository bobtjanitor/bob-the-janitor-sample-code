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
                Name = profile.Name
            };
            return item;
        }
    }
}