using System.Collections.Generic;
using Moq;
using SampleApplication.Domain;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;
using Xunit;

namespace SampleApplication.Domain_XUnit_Tests
{
    public class EmployeeRequests_Tests
    {
        private EmployeeRequests target = new EmployeeRequests();
        private Mock<IEmployeeRepository> MockEmployeeRepository = new Mock<IEmployeeRepository>();
        private IList<EmployeeDto> Expected = new List<EmployeeDto>{new EmployeeDto(), new EmployeeDto()};

        public void Action(string city, string state)
        {
            MockEmployeeRepository.Setup(x=>x.GetEmployeeByCityState(city,state)).Returns(Expected);
            target.EmployeeRepository = MockEmployeeRepository.Object;
            target.GetEmployeeByLocation(city, state);
        }

        [Fact]
        public void Calls_EmployeeRepository_Test()
        {
            var city = "TestCity";
            var state = "TestState";
            Action(city,state);
            MockEmployeeRepository.Verify(x=>x.GetEmployeeByCityState(city,state),Times.Once());
        }

    }
}
