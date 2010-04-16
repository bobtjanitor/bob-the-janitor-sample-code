using System;
using System.Collections.Generic;
using System.Linq;
using DriverLogger.Biz;
using NUnit.Framework;

namespace DriverLogger.Biz_NUnit_Test
{
    [TestFixture]
    public class SaveCurrentLog_Tests
    {
        private SaveCurrentLog target;

        [SetUp]
        public void Setup()
        {
            target = new SaveCurrentLog();
        }

        [Test]
        public void Validate_IfActivityIsEmptyReturnError_Test()
        {
            Log testLog = new Log {Activity = "", Date = DateTime.Now, Lat = 100, Lon = -100};
            var result =  target.Validate(testLog);
            var acctual = from 
                              error in result 
                          where 
                          error.Contains("Activity Required") 
                          select error;
            Assert.AreEqual(1, acctual.Count());
        }

        [Test]
        public void GetLatLonForCity_GetTheLatLonForASpecificCity_Test()
        {
            target.City = "Boise";
            target.State = "Id";
            target.GeoDataInterface = new MockIGeoData();

            Log testLog = target.GetLatLonForCity();

            Assert.AreEqual(100, testLog.Lat); 
        }

        [Test]
        public void GetLatLonForCity_GetTheLatLonForASpecificCityCallsGeoInterface_Test()
        {
           
            MockIGeoData testMock = new MockIGeoData();            
            target.GeoDataInterface = testMock;
            Log testLog = target.GetLatLonForCity();

            Assert.AreEqual(1, testMock.GeoDataInterfaceCalledCount);
        }

        public class MockIGeoData : IGeoData
        {
            public int GeoDataInterfaceCalledCount=0;

            public Log ReturnCityState(string city, string state)
            {
                GeoDataInterfaceCalledCount++;
                return new Log(){Lat = 100};
            }


        }
       
    }
}
