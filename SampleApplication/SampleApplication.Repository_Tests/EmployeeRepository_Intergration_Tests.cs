using System.Linq;
using NUnit.Framework;
using SampleApplication.Repository;

namespace SampleApplication.Repository_Tests
{
    [TestFixture]
    public class EmployeeRepository_Intergration_Tests
    {
        public EmployeeRepository target;
        public string City;
        public string State;

        [SetUp]
        public void Setup()
        {
            target = new EmployeeRepository();
            State = "Washington";
            City = "Seattle";
        }

        [Test]
        public void GettingEmployeesFromSpecifiedCityAndStateOnlyReturnsEmployeesFromTheir_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            var filtered = actaul.Where(x => x.City == City && x.State == State).ToList();
            Assert.AreEqual(actaul.Count, filtered.Count);
        }

        [Test]
        public void GettingEmployeesFromSpecifiedCityAndStateReturnsEmployees_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);            
            Assert.Greater(actaul.Count, 0);
        }

        [Test]
        public void ReturnsEmployeesCity_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            Assert.AreEqual(City, actaul[0].City);
        }

        [Test]
        public void ReturnsEmployeesState_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            Assert.AreEqual(State, actaul[0].State);
        }
    }
}