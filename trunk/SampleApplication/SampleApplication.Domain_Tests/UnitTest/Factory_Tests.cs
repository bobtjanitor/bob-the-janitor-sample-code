using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.UnitTest
{
    [TestFixture]
    public class Factory_Tests
    {
        [Test]
        public void GetEmployeeRepository_Test()
        {
            Assert.IsInstanceOf<IEmployeeRepository>(Factory.GetEmployeeRepository());
        }    
    }
}