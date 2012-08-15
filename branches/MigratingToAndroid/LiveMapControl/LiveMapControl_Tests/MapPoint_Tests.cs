using LiveMapControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiveMapControl_Tests
{
    /// <summary>
    ///This is a test class for MapPoint_Tests and is intended
    ///to contain all MapPoint_Tests Unit Tests
    ///</summary>
    [TestClass()]
    public class MapPoint_Tests
    {      
        /// <summary>
        ///A test for MapPoint Constructor
        ///</summary>
        [TestMethod()]
        public void MapPointConstructor_Test()
        {
            MapPoint target = new MapPoint();
            Assert.AreEqual(0, target.Lat);
            Assert.AreEqual(0, target.Lon);
            Assert.AreEqual(null, target.Name);
        }

        /// <summary>
        ///A test for Lat
        ///</summary>
        [TestMethod()]
        public void Lat_Test()
        {
            MapPoint target = new MapPoint(); 
            int expected = 5; 
            target.Lat = expected;
            int actual = target.Lat;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Lon
        ///</summary>
        [TestMethod()]
        public void Lon_Test()
        {
            MapPoint target = new MapPoint(); 
            int expected = 3; 
            target.Lon = expected;
            int actual = target.Lon;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void Name_Test()
        {
            MapPoint target = new MapPoint();
            string expected = "Test Name";
            target.Name = expected;
            string actual = target.Name;
            Assert.AreEqual(expected, actual);
        }
    }
}
