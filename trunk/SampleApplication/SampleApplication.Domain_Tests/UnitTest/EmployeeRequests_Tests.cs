using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.Dvrs;
using SampleApplication.Repository;

namespace SampleApplication.Domain_Tests
{
    [TestFixture]
    public class EmployeeRequests_Tests
    {
        private EmployeeRequests target;
        private Mock<IEmployeeRepository> MockEmployeeRepository;
        [SetUp]
        public void Setup()
        {
            target = new EmployeeRequests();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState(It.IsAny<string>(), It.IsAny<string>())).Returns(new List<EmployeeDvr>() {new EmployeeDvr() {City = "Seattle", State = "Washington", EmployeeName = "bob"}});
            target.EmployeeRepository = MockEmployeeRepository.Object;
        }

        [Test]
        public void ReturnsErrorForEmptyCity_Test()
        {
            target.GetEmployeeByLocation(string.Empty, "Washington");
            var actual = target.Errors.Where(x => x.Contains("Invalid City"));
            Assert.AreEqual(1,actual.Count());
        }

        [Test]
        public void ReturnsErrorForEmptyState_Test()
        {
            target.GetEmployeeByLocation("Seattle", string.Empty);
            var actual = target.Errors.Where(x => x.Contains("Invalid State"));
            Assert.AreEqual(1, actual.Count());
        }

        [Test]
        public void VailidCityStateCallRepository_Test()
        {
            target.GetEmployeeByLocation("Seattle", "Washington");
            MockEmployeeRepository.Verify(x => x.GetEmployeeByCityState("Seattle", "Washington"));
        }     
    }
}
