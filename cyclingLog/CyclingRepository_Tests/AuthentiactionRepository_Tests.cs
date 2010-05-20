using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyclingRepository;
using NUnit.Framework;

namespace CyclingRepository_Tests
{
    [TestFixture]
    public class AuthentiactionRepository_Intergration_Tests
    {
        private AuthentiactionRepository target;
        
        [SetUp]
        public void Setup()
        {
            target = new AuthentiactionRepository();
        }

        [Test]
        public void CheckAuthentication_ValidUserReturnsTrue_Intergration_Test()
        {
            bool actual = target.CheckAuthentication("bobtjanitor", "zxasqw12");
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckAuthentication_ValidUserSetsAuthenticatedUser_Intergration_Test()
        {
            bool actual = target.CheckAuthentication("bobtjanitor", "zxasqw12");
            Assert.AreEqual("d2524eca-69b9-4b95-be25-019beffeb22a",target.AuthenticatedUser.ToString());
        }

        [Test]
        public void CheckAuthentication_InvalidUserReturnsFalse_Intergration_Test()
        {
            bool actual = target.CheckAuthentication("bobtjanitor", "zxasqw");
            Assert.IsFalse(actual);
        }
    }
}
