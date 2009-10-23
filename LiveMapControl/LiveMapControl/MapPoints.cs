using System.Collections.ObjectModel;

namespace LiveMapControl
{
    public class MapPoint
    {
        public int Lat { get; set; }
        public int Lon { get; set; }
        public string Name { get; set; }
    }

    public class MapPoints : Collection<MapPoint>
    {
    }

}
