using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class When_Requesting_Employees_From_Seattle_Washington_Tests : Test_Context<EmployeeRequests>
    {
        public Mock<IEmployeeRepository> MockEmployeeRepository;

        public override void Context()
        {
            base.Context();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState("Seattle", "Washington"))
                .Returns(new List<EmployeeDto> { new EmployeeDto { City = "Seattle", State = "Washington" } });
            Target.EmployeeRepository = MockEmployeeRepository.Object;
        }

        public override void Because()
        {
            Target.GetEmployeeByLocation("Seattle", "Washington");
        }

        [Test]
        public void HasNoErrors_Test()
        {
            Assert.AreEqual(0,Target.Errors.Count);
        }   
     
        [Test]
        public void Calls_The_Repository()
        {
            MockEmployeeRepository.Verify(x=>x.GetEmployeeByCityState("Seattle","Washington"),Times.Once());
        }
    }
}
