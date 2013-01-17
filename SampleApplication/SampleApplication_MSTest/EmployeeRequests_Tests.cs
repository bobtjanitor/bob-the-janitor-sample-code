using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleApplication.Domain;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication_MSTest
{
    [TestClass]
    public class EmployeeRequests_Tests
    {
        public EmployeeRequests Target;
        public Mock<IEmployeeRepository> EmployeeRepositoryMock;
        public string ExpectedCity;
        public string ExpectedState;
        public IList<EmployeeDto> Expected;
        public IList<EmployeeDto> Actual;

        [TestInitialize]
        public void SetUp()
        {
            ExpectedCity = "TestCity";
            ExpectedState = "Id";
            Expected = new List<EmployeeDto>{new EmployeeDto(), new EmployeeDto(), new EmployeeDto()};
            EmployeeRepositoryMock = new Mock<IEmployeeRepository>();
            EmployeeRepositoryMock.Setup(x => x.GetEmployeeByCityState(ExpectedCity, ExpectedState))
                                  .Returns(Expected);
            Target = new EmployeeRequests { EmployeeRepository = EmployeeRepositoryMock.Object };
            Actual = Target.GetEmployeeByLocation(ExpectedCity, ExpectedState);
        }

        [TestMethod]
        public void Calls_EmployeeRepository_GetEmployeeByCityState_Test()
        {
            EmployeeRepositoryMock.Verify(x => x.GetEmployeeByCityState(ExpectedCity, ExpectedState), Times.Once());
        }
    }
}
