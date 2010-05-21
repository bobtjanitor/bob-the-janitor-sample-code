using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyclingRepository;
using NUnit.Framework;

namespace CyclingRepository_Tests
{
    [TestFixture]
    public class ProfilesRepository_Intergration_Tests
    {
        private ProfilesRepository target;

        [SetUp]
        public void Setup()
        {
            target = new ProfilesRepository();
        }

        [Test]
        public void GetProfileList_ReturnsData_Test()
        {
            var actual = target.GetProfileList();
            Assert.IsTrue(actual.Count>0);
        }
    }
}
