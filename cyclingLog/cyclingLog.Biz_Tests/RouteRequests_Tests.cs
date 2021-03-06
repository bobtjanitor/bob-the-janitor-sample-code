﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using cyclingLog.Biz;
using DomainModels;
using DomainModels.RepositoryInterfaces;
using NUnit.Framework;

namespace cyclingLog.Biz_Tests
{
    [TestFixture]
    public class RouteRequests_Tests
    {
        private RouteRequests target;
        private Route testRoute;
        private MockRouteRepository mockRouteRepository;
        private MockRoutesRepository _mockRoutesRepository;

        [SetUp]
        public void Setup()
        {
            target = new RouteRequests();
            testRoute = new Route {Name = "test route", Location = "test location", Id = Guid.NewGuid()};
            mockRouteRepository = new MockRouteRepository();
            target.RouteRepositoryInterface = mockRouteRepository;
            _mockRoutesRepository = new MockRoutesRepository();
            target.RoutesRepositoryInterface = _mockRoutesRepository;
        }

        [Test]
        public void AddRoute_ValidRouteReturnsNoError_Test()
        {
            mockRouteRepository.AddUpdateRouteReturnValue = true;
            target.AddRoute(testRoute);
            Assert.AreEqual(0,target.Errors.Count());
        }

        [Test]
        public void AddRoute_ValidRouteReturnsTrue_Test()
        {
            mockRouteRepository.AddUpdateRouteReturnValue = true;
            bool actual = target.AddRoute(testRoute);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void AddRoute_NoNameInRouteReturnsAnError_Test()
        {
            testRoute.Name = string.Empty;
            target.AddRoute(testRoute);
            var result = from error in target.Errors where error.Contains("Name is required") select error;
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void AddRoute_NoNameInRouteReturnsFalse_Test()
        {
            testRoute.Name = string.Empty;
            bool sucess = target.AddRoute(testRoute);
            Assert.AreEqual(false, sucess);
        }

        [Test]
        public void AddRoute_NoLocationReturnsAnError_Test()
        {
            testRoute.Location = string.Empty;
            target.AddRoute(testRoute);
            var result = from error in target.Errors where error.Contains("Location is required") select error;
            Assert.AreEqual(1,result.Count());
        }

        [Test]
        public void AddRoute_NoLocationReturnsFalse_Test()
        {
            testRoute.Location = string.Empty;
            bool actual = target.AddRoute(testRoute);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void AddRoute_NoIdReturnsAnError_Test()
        {
            testRoute.Id = new Guid();
            target.AddRoute(testRoute);
            var result = from error in target.Errors where error.Contains("Invalid route Id") select error;
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void AddRoute_NoIdReturnsFalse_Test()
        {
            testRoute.Id = new Guid();
            testRoute.Location = string.Empty;
            bool actual = target.AddRoute(testRoute);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void AddRoute_ValidRouteCallsAddUpDateRouteInRepository_Test()
        {
            target.AddRoute(testRoute);
            Assert.AreEqual(1,mockRouteRepository.AddUpdateRouteCalledCount);
        }

        [Test]
        public void AddRoute_InvalidRouteCallsAddUpDateRouteInRepository_Test()
        {
            testRoute.Name = string.Empty;
            target.AddRoute(testRoute);
            Assert.AreEqual(0, mockRouteRepository.AddUpdateRouteCalledCount);
        }

        [Test]
        public void AddRoute_RepositoryReturnsErrorReturnsAnError_Test()
        {
            mockRouteRepository.AddUpdateRouteReturnValue = false;
            target.AddRoute(testRoute);
            var result = from error in target.Errors where error.Contains("An error occured saving this route") select error;
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void AddRoute_RepositoryReturnFalseReturnsFalse_Test()
        {
            mockRouteRepository.AddUpdateRouteReturnValue = false;
            bool actual = target.AddRoute(testRoute);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void GetRoutes_CallsRoutesRepositoryForAListOfRoutes_Test()
        {
            target.GetRoutes();
            Assert.AreEqual(1,_mockRoutesRepository.GetAllRoutesCalledCount);
        }

    }

    public class MockRoutesRepository : IRoutesRepository
    {
        public List<Route> GetUsersRoutesReturnValue = new List<Route>();
        public int GetUsersRoutesCalledCount=0;
        public Route GetRouteByIdReturnValue=new Route();
        public int GetRouteByIdCalledCount=0;
        public Routes GetAllRoutesReturnValue=new Routes();
        public int GetAllRoutesCalledCount;

        public List<Route> GetUsersRoutes(Guid userId)
        {
            GetUsersRoutesCalledCount++;
            return GetUsersRoutesReturnValue;           
        }

        public Route GetRouteById(Guid routeId)
        {
            GetRouteByIdCalledCount++;
            return GetRouteByIdReturnValue;
        }

        public Routes GetAllRoutes()
        {
            GetAllRoutesCalledCount++;
            return GetAllRoutesReturnValue;
        }
    }

    public class MockRouteRepository : IRouteRepository
    {
        public int AddUpdateRouteCalledCount=0;
        public bool AddUpdateRouteReturnValue = false;

        public bool AddUpdateRoute(Route route)
        {
            AddUpdateRouteCalledCount++;
            return AddUpdateRouteReturnValue;
        }
    }
}
