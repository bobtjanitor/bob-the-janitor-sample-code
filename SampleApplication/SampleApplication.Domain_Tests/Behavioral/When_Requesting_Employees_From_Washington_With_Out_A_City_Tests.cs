using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class When_Requesting_Employees_From_Washington_With_Out_A_City_Tests : Test_Context<EmployeeRequests>
    {
        public Mock<IEmployeeRepository> MockEmployeeRepository;

        public override void Context()
        {
            base.Context();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState("Seattle", "Washington"))
                .Returns(new List<EmployeeDto>
                             {
                                 new EmployeeDto { City = "Seattle", State = "Washington" }
                             });
            Target.EmployeeRepository = MockEmployeeRepository.Object;
        }

        public override void Because()
        {
            Target.GetEmployeeByLocation(string.Empty, "Washington");
        }

        [Test]
        public void HasNoErrors_Test()
        {
            Assert.AreEqual(1, Target.Errors.Count);
        }

        [Test]
        public void Do_Not_Call_The_Repository()
        {
            MockEmployeeRepository.Verify(x => x.GetEmployeeByCityState(It.IsAny<string>(),It.IsAny<string>()), Times.Never());
        }
    }
}