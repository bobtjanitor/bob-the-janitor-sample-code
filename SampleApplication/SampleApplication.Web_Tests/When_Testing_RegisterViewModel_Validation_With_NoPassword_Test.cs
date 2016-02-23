using System.Linq;
using NUnit.Framework;
using SampleApplication.Web.Models;

namespace SampleApplication.Web_Tests
{
    [TestFixture]
    public class When_Testing_RegisterViewModel_Validation_With_NoPassword_Test : ViewModelValidation_Context<RegisterViewModel>
    {
        public override void Context()
        {
            base.Context();
            Target.Email = "TestEmail@email.com";
            Target.Password = string.Empty;
            Target.ConfirmPassword = "TestPass";
        }

        [Test]
        public void Fail_Validation_Test()
        {
            Assert.IsFalse(Actual);
        }

        [Test]
        public void Has_No_ValidationMessages_Test()
        {
            Assert.IsTrue(ActualMessages.Any());
        }

        [TestCase("The Password field is required.")]
        [TestCase("The password and confirmation password do not match.")]
        public void Has_Expected_Validation_ErrorMessages_Test(string message)
        {
            Assert.IsTrue(ActualMessages.Any(x=>x.ErrorMessage== message));
        }

        [TestCase("Password")]
        public void Has_Expected__ValidationMessages_Test(string memberName)
        {
            Assert.IsTrue(ActualMessages.Any(x => x.MemberNames.Contains(memberName)));
        }
    }
}