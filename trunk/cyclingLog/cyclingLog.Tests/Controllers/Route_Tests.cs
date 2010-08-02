using System;
using System.Collections.Generic;
using cyclingLog.Controllers;
using DomainModels;
using DomainModels.BizInterfaces;
using DomainModels.RepositoryInterfaces;
using NUnit.Framework;

namespace cyclingLog.Tests.Controllers
{
    [TestFixture]
    public class Route_Tests
    {
        RouteController target;
        private MockRouteRequests _mockRouteRequests;
        [SetUp]
        public void Setup()
        {
            target = new RouteController();
            _mockRouteRequests = new MockRouteRequests();
            target.RouteRequestsInterface = _mockRouteRequests;
        }

        [Test]
        public void RouteList_CallsRouteRequestsForListOfRoutes_Test()
        {
            target.RouteList();
            Assert.AreEqual(1,_mockRouteRequests.GetRoutesCalledCount);
        }
    }

    public class MockRouteRequests : IRouteRequests
    {
        public int GetRoutesCalledCount=0;
        public Routes GetRoutesReturnValue = new Routes();
        public IRouteRepository RouteRepositoryInterface { get; set; }
        public List<string> Errors { get; set; }

        public bool AddRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public Routes GetRoutes()
        {
            GetRoutesCalledCount++;
            return GetRoutesReturnValue;
        }
    }
}
