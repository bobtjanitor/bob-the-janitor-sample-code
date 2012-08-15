using System;

namespace ObserverDemo
{
    public class FakeLocationRepository : ILocationReposigtory
    {
        public bool SaveLocation(Location location)
        {
            Console.WriteLine(string.Format("Saved the location Lat {0} and Lon {1} ",location.Lat,location.Lon));
            return true;
        }
    }
}