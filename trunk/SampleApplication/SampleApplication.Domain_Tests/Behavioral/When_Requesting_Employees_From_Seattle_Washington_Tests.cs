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
            MockEmployeeRepository.Setup(x => x.GetEmployeeByCityState("Seattle", "Washington")).Returns<List<EmployeeDvr>>(
                x => new List<EmployeeDvr>() { new EmployeeDvr() { City = "Seattle", State = "Washington" } });
            Target.EmployeeRepository = MockEmployeeRepository.Object;
        }

        public override void Becouse()
        {
            Target.GetEmployeeByLocation("Seattle", "Washington");
        }

        [Test]
        public void HasNoErrors_Test()
        {
            Assert.AreEqual(0,Target.Errors.Count);
        }        
    }
}
