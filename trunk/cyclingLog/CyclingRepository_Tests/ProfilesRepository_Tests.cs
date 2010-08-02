using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyclingRepository;
using DomainModels;
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

        [Test]
        public void GetProfileById_ReturnsAProfileWithAValidId_Test()
        {
            Guid expected = Guid.Parse("d2524eca-69b9-4b95-be25-019beffeb22a");
            Profile actual = target.GetProfileById(expected);
            Assert.AreEqual(expected,actual.Id);

        }
    }
}
