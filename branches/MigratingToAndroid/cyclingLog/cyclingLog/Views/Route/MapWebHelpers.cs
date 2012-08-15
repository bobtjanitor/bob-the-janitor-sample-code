using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using DomainModels;

namespace cyclingLog.Views.Route
{
    public static class MapWebHelpers
    {
        public static string AddRouteToMap(this HtmlHelper helper, string mapName, IList<LatLonCoordinate> latLonCoordinates )
        {
            StringBuilder routeData = new StringBuilder();
            routeData.AppendLine("var route = [");
            for (int i = 0; i < latLonCoordinates.Count; i++)
            {
                routeData.AppendFormat("new VELatLong({0}, {1})", latLonCoordinates[i].Lat, latLonCoordinates[i].Lon);
                if(i+1 != latLonCoordinates.Count)
                {
                    routeData.AppendLine(",");
                }

            }
            routeData.AppendLine("];");
            routeData.AppendFormat("{0}.GetDirections(route);\n", mapName);
            return routeData.ToString();
        }
    }
}