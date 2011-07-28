using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SampleApplication.Objects.Dvrs;
using SampleApplication.Repository;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class When_Requesting_Employees_From_Seattle_Washington_Tests : EmployeeRequests_Context
    {
        public override void Context()
        {
            base.Context();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState("Seattle", "Washington")).Returns(new List<EmployeeDvr>() { new EmployeeDvr() { City = "Seattle", State = "Washington" } });
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

    [TestFixture]
    public class When_Requesting_Employees_From_Washington_With_Out_A_City_Tests : EmployeeRequests_Context
    {
        public override void Context()
        {
            base.Context();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState("Seattle", "Washington")).Returns(new List<EmployeeDvr>() { new EmployeeDvr() { City = "Seattle", State = "Washington" } });
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
