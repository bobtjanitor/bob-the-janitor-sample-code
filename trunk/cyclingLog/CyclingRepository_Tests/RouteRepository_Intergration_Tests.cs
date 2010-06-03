using System;
using Amazon.SimpleDB.Model;
using CyclingRepository;
using DomainModels;
using NUnit.Framework;
using Amazon.SimpleDB;

namespace CyclingRepository_Tests
{
    [TestFixture]
    public class RouteRepository_Intergration_Tests : SimpleDBRepositoryBase
    {
        private RouteRepository target;
        private Route testRoute;

        [SetUp]
        public void Setup()
        {
            target = new RouteRepository();
        }

        [TearDown]
        public void TearDown()
        {
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                DeleteAttributesRequest request = new DeleteAttributesRequest();
                request.DomainName = RouteRepository.DomainName;
                request.ItemName = testRoute.Id.ToString();
                client.DeleteAttributes(request);
            }
        }

        [Test]
        public void AddUpdateRoute_Intergration_Test()
        {
            testRoute = new Route(){Distance = 10,Id = Guid.NewGuid(), LastTimeRidden=DateTime.Today, Location = "Boise", Name = "test route"};
            bool success = target.AddUpdateRoute(testRoute);
            Assert.IsTrue(success);
        }


    }
}
