using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cyclingLog.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<RouteModel> RouteList { get; set; }
    }

    public class RouteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }

    }
}