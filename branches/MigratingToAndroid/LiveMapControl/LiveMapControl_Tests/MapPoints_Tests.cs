using LiveMapControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiveMapControl_Tests
{
    
    
    /// <summary>
    ///This is a test class for MapPoints_Tests and is intended
    ///to contain all MapPoints_Tests Unit Tests
    ///</summary>
    [TestClass()]
    public class MapPoints_Tests
    {               
        /// <summary>
        ///A test for MapPoints Constructor
        ///</summary>
        [TestMethod()]
        public void MapPoints_HasNoItems_Test()
        {
            MapPoints target = new MapPoints();
            Assert.AreEqual(0, target.Count);
        }

        [TestMethod()]
        public void MapPoints_HasOneItem_Test()
        {
            MapPoints target = new MapPoints();
            target.Add(new MapPoint() { Lat = 1, Lon = 2, Name = "test Name" });
            Assert.AreEqual(1, target.Count);
        }
    }
}
