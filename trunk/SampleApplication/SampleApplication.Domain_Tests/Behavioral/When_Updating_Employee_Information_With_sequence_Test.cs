using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.DomainInterfaces;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class When_Updating_Employee_Information_With_sequence_Test : Test_Context<EmployeeRequests>
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
        public int Counter;
        public Dictionary<string, int> Sequence; 

        public override void Context()
        {
            base.Context();
            UserId = 12;
            EmployeeId = 14;
            Expected = true;
            ExpectedAuth = true;
            UpdateEmployee = new EmployeeDto { Id = EmployeeId };
            Counter = 0;
            Sequence = new Dictionary<string, int>();
            Target.User.Id = UserId;
            AuthRequestsMock = new Mock<IAuthRequests>();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();

            AuthRequestsMock.Setup(x => x.UserCanUpdateEmployee(UserId, EmployeeId))
                .Callback(() => Sequence.Add("AuthRequests.UserCanUpdateEmployee", Counter++)).Returns(ExpectedAuth);
            MockEmployeeRepository.Setup(x => x.UpdateEmployee(It.IsAny<EmployeeDto>()))
                .Callback<EmployeeDto>(x =>
                                           {
                                               SentEmployee = x;
                                               Sequence.Add("EmployeeRepository.UpdateEmployee", Counter++);
                                           }).Returns(Expected);

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
            AuthRequestsMock.Verify(x => x.UserCanUpdateEmployee(UserId, EmployeeId), Times.Once());
        }

        [Test]
        public void Calls_AuthRequests_UserCanUpdateEmployee_Inorder_Test()
        {
            Assert.AreEqual(0, Sequence["AuthRequests.UserCanUpdateEmployee"]);
        }

        [Test]
        public void Calls_EmployeeRepository_UpdateEmployee_Test()
        {
            MockEmployeeRepository.Verify(x => x.UpdateEmployee(It.IsAny<EmployeeDto>()), Times.Once());
        }

        [Test]
        public void Calls_EmployeeRepository_UpdateEmployee_Inorder_Test()
        {
            Assert.AreEqual(1, Sequence["EmployeeRepository.UpdateEmployee"]);
        }

        [Test]
        public void Sends_expected_Emplyee_test()
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