using System.Text.RegularExpressions;
using cyclingLog.Views.Route;
using System.Web.Mvc;
using DomainModels;
using System.Collections.Generic;
using NUnit.Framework;

namespace cyclingLog.Tests
{
    /// <summary>
    ///This is a test class for MapWebHelpers_Tests and is intended
    ///to contain all MapWebHelpers_Tests Unit Tests
    ///</summary>
    [TestFixture()]
    public class MapWebHelpers_Tests
    {
        [Test]
        public void AddRouteToMap_ReturnsAddingRouteToTheMapNamePassedIn_Test()
        {
            HtmlHelper helper = null; 
            string mapName = "TestMap"; 
            IList<LatLonCoordinate> latLonCoordinates = new List<LatLonCoordinate>(); 
            
            string actual = helper.AddRouteToMap(mapName, latLonCoordinates);
            Assert.IsTrue(actual.Contains(mapName + ".GetDirections(route);"));
        }

        [Test]
        public void AddRouteToMap_AddsAVELatLongWithTheCordsPassedIn_Test()
        {
            HtmlHelper helper = null;
            string mapName = "TestMap";
            IList<LatLonCoordinate> latLonCoordinates = new List<LatLonCoordinate>()
            {
                new LatLonCoordinate()
                    {
                        Lat = 12,
                        Lon = 10
                    }
            }; 

            string actual = helper.AddRouteToMap(mapName, latLonCoordinates);
            Assert.IsTrue(actual.Contains("new VELatLong(12, 10)"));
        }

        [Test]
        public void AddRouteToMap_AddsAVELatLongForEachofTheCordsPassedIn_Test()
        {
            HtmlHelper helper = null;
            string mapName = "TestMap";
            IList<LatLonCoordinate> latLonCoordinates = new List<LatLonCoordinate>()
            {
                new LatLonCoordinate(){Lat = 12,Lon = 10},
                new LatLonCoordinate(){Lat = 12,Lon = 10},
                new LatLonCoordinate(){Lat = 12,Lon = 10}
            };

            string actual = helper.AddRouteToMap(mapName, latLonCoordinates);
            Assert.AreEqual(latLonCoordinates.Count, Regex.Matches(actual,@"new VELatLong").Count);
        }
    }
}
