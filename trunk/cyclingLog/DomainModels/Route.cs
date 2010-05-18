using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class Route
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public string Location { get; set; }
        public DateTime LastTimeRidden { get; set; }
        public IList<LatLonCoordinate> RouteCoordinates { get; set; } 
    }

    public struct LatLonCoordinate
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

}