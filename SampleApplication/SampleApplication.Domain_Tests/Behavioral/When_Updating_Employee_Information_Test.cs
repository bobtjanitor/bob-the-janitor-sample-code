using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.DomainInterfaces;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class When_Updating_Employee_Information_Test: Test_Context<EmployeeRequests>
    {
        public Mock<IAuthRequests> AuthRequestsMock;
        public bool ExpectedAuth;
        public int UserId;
        public int EmployeeId;
        public bool Actual;
        public bool Expected;
        public EmployeeDto UpdateEmployee;
        public EmployeeDto SentEmployee;
        public UserDto ExpectedUser;
        public Mock<IEmployeeRepository> MockEmployeeRepository;

        public override void Context()
        {
            base.Context();
            UserId = 12;
            EmployeeId = 14;
            Expected = true;
            ExpectedAuth = true;
            UpdateEmployee = new EmployeeDto{Id = EmployeeId};
            Target.User.Id = UserId;
            AuthRequestsMock = new Mock<IAuthRequests>();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            
            AuthRequestsMock.Setup(x => x.UserCanUpdateEmployee(UserId, EmployeeId)).Returns(ExpectedAuth);
            MockEmployeeRepository.Setup(x => x.UpdateEmployee(It.IsAny<EmployeeDto>())).Callback<EmployeeDto>(
                x => SentEmployee = x).Returns(Expected);

            Target.AuthRequests = AuthRequestsMock.Object;
            Target.EmployeeRepository = MockEmployeeRepository.Object;
        }

        public override void Because()
        {
            Actual = Target.UpdateEmployee(UpdateEmployee);
        }

        [Test]
        public void Calls_AuthRequests_UserCanUpdateEmployee_Test()
        {
            AuthRequestsMock.Verify(x=>x.UserCanUpdateEmployee(UserId, EmployeeId), Times.Once());
        } 

        [Test]
        public void Calls_EmployeeRepository_UpdateEmployee_Test()
        {
            MockEmployeeRepository.Verify(x => x.UpdateEmployee(It.IsAny<EmployeeDto>()), Times.Once());
        }

        [Test]
        public  void Sends_expected_Emplyee_test()
        {
            Assert.AreEqual(UpdateEmployee.Id, SentEmployee.Id);
        }

        [Test]
        public void Returns_Expected_Result_Test()
        {
            Assert.IsTrue(Actual);
        }
    }
}