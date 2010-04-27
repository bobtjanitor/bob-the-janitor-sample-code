using System.Collections.Generic;
using cyclingLog.Models;
using DomainModels;

namespace cyclingLog
{
    public static class Extenders
    {
        public static List<ProfileModel> AsProfileModelList(this Profiles profiles)
        {
            List<ProfileModel> list = new List<ProfileModel>();
            foreach (Profile profile in profiles)
            {
                ProfileModel item = new ProfileModel
                                        {
                                            Description = profile.Description,
                                            Id = profile.Id,
                                            Name = profile.Name
                                        };
                list.Add(item);
            }
            return list;
        }
    }
}