using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.UnitTest
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
            MockEmployeeRepository.Setup(x => 
                x.GetEmployeeByCityState(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(new List<EmployeeDto>
                             {
                                 new EmployeeDto {City = "Seattle", State = "Washington", FirstName = "bob"}
                             });
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
            MockEmployeeRepository.Verify(x => x.GetEmployeeByCityState("Seattle", "Washington"), Times.Once());
        }     
        
        [Test]
        [TestCase("Boise", "Id")]
        [TestCase("Nampa", "Id")]
        [TestCase("Rexburg", "Id")]
        [TestCase("Eagle", "Id")]
        public void Testing_With_TestCase_Test(string city, string state)
        {
            target.GetEmployeeByLocation(city, state);
            MockEmployeeRepository.Verify(x => x.GetEmployeeByCityState(city, state));
        }
    }
}
