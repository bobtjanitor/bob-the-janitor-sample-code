using System.Linq;
using cyclingLog.Biz;
using NUnit.Framework;

namespace cyclingLog.Biz_Tests
{
    [TestFixture]
    public class Authentication_Tests
    {
        private Authentication target; 

        [SetUp]
        public void Setup()
        {
            target = new Authentication();
        }

        [Test]
        public void Authenticate_MissingUserNameAddsError_Test()
        {
            target.Username = string.Empty;
            target.Authenticate();
            var result = from error in target.ValidationErrors where error.Contains("Username Required") select error;
            Assert.AreEqual(1,result.Count());
        }

        [Test]
        public void Authenticate_MissingUserNameRetuensFalse_Test()
        {
            target.Password = "test";
            target.Username = string.Empty;
            bool actual = target.Authenticate();

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Authenticate_ContainsUserNameDoNotAddError_Test()
        {
            target.Username = "test";
            target.Authenticate();
            var result = from error in target.ValidationErrors where error.Contains("Username Required") select error;
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public void Authenticate_MissingPasswordAddsError_Test()
        {
            target.Password = string.Empty;
            target.Authenticate();
            var result = from error in target.ValidationErrors where error.Contains("Password Required") select error;
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void Authenticate_MissingPasswordRetuensFalse_Test()
        {
            target.Username = "test";
            target.Password = string.Empty;
            bool actual = target.Authenticate();

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Authenticate_ContainsPasswordDoNotAddError_Test()
        {
            target.Password = "test";
            target.Authenticate();
            var result = from error in target.ValidationErrors where error.Contains("Password Required") select error;
            Assert.AreEqual(0, result.Count());
        }
    }
}
