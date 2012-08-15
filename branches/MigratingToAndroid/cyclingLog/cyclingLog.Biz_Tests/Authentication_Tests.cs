using System;
using System.Linq;
using cyclingLog.Biz;
using DomainModels.RepositoryInterfaces;
using NUnit.Framework;

namespace cyclingLog.Biz_Tests
{
    [TestFixture]
    public class Authentication_Tests
    {
        private Authentication target;
        private MockAuthentiactionRepository mockAuthentiactionRepository;

        [SetUp]
        public void Setup()
        {
            target = new Authentication();
            mockAuthentiactionRepository = new MockAuthentiactionRepository();
            target.AuthenticationRepositoryInterface = mockAuthentiactionRepository;
        }

        [Test]
        public void Authenticate_MissingUserNameAddsError_Test()
        {
            target.Username = string.Empty;
            target.Authenticate();
            var result = from error in target.ValidationErrors where error.Contains("Username Required") select error;
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void Authenticate_clearsErrorsWhenCalled_Test()
        {
            target.Username = string.Empty;
            target.Authenticate();
            var actaul = target.Errors.Count();
            Assert.AreEqual(1, actaul);
            target.Authenticate();
            Assert.AreEqual(1, actaul);
        }

        //[Test]
        //public void Authenticate_MissingUserNameRetuensFalse_Test()
        //{
        //    target.Password = "test";
        //    target.Username = string.Empty;
        //    bool actual = target.Authenticate();

        //    Assert.AreEqual(false, actual);
        //}

        //[Test]
        //public void Authenticate_ContainsUserNameDoNotAddError_Test()
        //{
        //    target.Username = "test";
        //    target.Authenticate();
        //    var result = from error in target.ValidationErrors where error.Contains("Username Required") select error;
        //    Assert.AreEqual(0, result.Count());
        //}

        //[Test]
        //public void Authenticate_MissingPasswordAddsError_Test()
        //{
        //    target.Password = string.Empty;
        //    target.Authenticate();
        //    var result = from error in target.ValidationErrors where error.Contains("Password Required") select error;
        //    Assert.AreEqual(1, result.Count());
        //}

        //[Test]
        //public void Authenticate_MissingPasswordRetuensFalse_Test()
        //{
        //    target.Username = "test";
        //    target.Password = string.Empty;
        //    bool actual = target.Authenticate();

        //    Assert.AreEqual(false, actual);
        //}

        //[Test]
        //public void Authenticate_ContainsPasswordDoNotAddError_Test()
        //{
        //    target.Password = "test";
        //    target.Authenticate();
        //    var result = from error in target.ValidationErrors where error.Contains("Password Required") select error;
        //    Assert.AreEqual(0, result.Count());
        //}

        //[Test]
        //public void Authenticate_DoNotCallRepositoryWithValidationErrors_Test()
        //{
        //    target.Password = "test";
        //    target.Authenticate();
          
        //    Assert.AreEqual(0, mockAuthentiactionRepository.CheckAuthenticationCalledCount);
        //}

        [Test]
        public void Authenticate_CallRepositoryWithNoValidationErrors_Test()
        {
            target.Password = "test";
            target.Username = "bob";
                
            target.Authenticate();

            Assert.AreEqual(1, mockAuthentiactionRepository.CheckAuthenticationCalledCount);
        }

        [Test]
        public void Authenticate_ValidAuthenticationAuthID_Test()
        {
            target.Password = "test";
            target.Username = "bob";
            mockAuthentiactionRepository.AuthenticatedUser = new Guid();

            target.Authenticate();

            Assert.AreEqual(mockAuthentiactionRepository.AuthenticatedUser, target.AuthenticatedUserId);
        }
    }

    public class MockAuthentiactionRepository : IAuthentiactionRepository
    {
        public int CheckAuthenticationCalledCount=0;
        public bool CheckAuthenticationReturnValue = true;
        public Guid AuthenticatedUser { get; set; }
        public bool CheckAuthentication(string userName, string password)
        {
            CheckAuthenticationCalledCount++;
            return CheckAuthenticationReturnValue;
        }
    }
}
