using System;
using CyclingRepository;
using DomainModels;
using NUnit.Framework;

namespace CyclingRepository_Tests
{
    [TestFixture]
    public class RoutesRepository_Tests : SimpleDBRepositoryBase
    {

        private RoutesRepository target;

        [SetUp]
        public void Setup()
        {
            target = new RoutesRepository();
        }

        [Test]
        public void GetUsersRoutes_ValidIdWithRoutesReturnsRoute_Intergration_Test()
        {
            Guid testUser = Guid.Parse("d2524eca-69b9-4b95-be25-019beffeb22a");
            Assert.AreEqual(true, target.GetUsersRoutes(testUser).Count>0);
        }

        [Test]
        public void GetRouteById_ValidRouteIdReturnsRouteWithSameId_Intergration_Test()
        {
            Guid testRoute = Guid.Parse("89fe3d35-5eeb-402e-b0ea-983e5f42a13c");
            Assert.AreEqual(testRoute, target.GetRouteById(testRoute).Id);
        }

        [Test]
        public void GetRouteById_ValidRouteIdReturnsRouteWithExpectedDistance_Intergration_Test()
        {
            Guid testRoute = Guid.Parse("89fe3d35-5eeb-402e-b0ea-983e5f42a13c");
            Assert.AreEqual(100, target.GetRouteById(testRoute).Distance);
        }

        [Test]
        public void GetRouteById_ValidRouteIdReturnsRouteWithExpectedLastTimeRidden_Intergration_Test()
        {
            Guid testRoute = Guid.Parse("89fe3d35-5eeb-402e-b0ea-983e5f42a13c");
            Assert.AreEqual(DateTime.Parse("12/12/2009").ToShortDateString(), target.GetRouteById(testRoute).LastTimeRidden.ToShortDateString());
        }

        [Test]
        public void GetAllRoutes_ReturnsRoutes_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreEqual(true, routes.Count>0);
        }

        [Test]
        public void GetAllRoutes_ReturnedRoutesDistanceIsSet_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreEqual(true, routes[0].Distance > 0);
        }

        [Test]
        public void GetAllRoutes_ReturnedRoutesIdIsSet_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreNotEqual(new Guid().ToString(), routes[0].Id.ToString());
        }

        [Test]
        public void GetAllRoutes_ReturnedRoutesLastTimeRiddenIsSet_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreNotEqual(new DateTime().ToShortDateString(), routes[0].LastTimeRidden.ToShortDateString());
        }

        [Test]
        public void GetAllRoutes_ReturnedRoutesLocationIsSet_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreNotEqual(0, routes[0].Location.Length);
        }

        [Test]
        public void GetAllRoutes_ReturnedRoutesNameIsSet_Intergration_Test()
        {
            Routes routes = target.GetAllRoutes();
            Assert.AreNotEqual(0, routes[0].Name.Length);
        }
       
    }
}
