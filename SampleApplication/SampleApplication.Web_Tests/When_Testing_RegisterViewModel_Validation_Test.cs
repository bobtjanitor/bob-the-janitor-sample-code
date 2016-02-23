using System.Linq;
using NUnit.Framework;
using SampleApplication.Web.Models;

namespace SampleApplication.Web_Tests
{
    [TestFixture]
    public class When_Testing_RegisterViewModel_Validation_Test : ViewModelValidation_Context<RegisterViewModel>
    {
        public override void Context()
        {
            base.Context();
            Target.Email = "TestEmail@email.com";
            Target.Password = "TestPass";
            Target.ConfirmPassword = "TestPass";
        }

        [Test]
        public void Passed_Validation_Test()
        {
            Assert.IsTrue(Actual);
        }

        [Test]
        public void Has_No_ValidationMessages_Test()
        {
            Assert.IsFalse(ActualMessages.Any());
        }
    }
}