using System.Linq;
using NUnit.Framework;
using SampleApplication.Objects.Dtos;
using SampleApplication.Repository;

namespace SampleApplication.Repository_Tests
{
    [TestFixture]
    public class When_Updating_Employee_Tests
    {
        public vEmployee Expected;
        public vEmployee Actual;
        public string OldFistName;
        public string OldLastName;
        public EmployeeRepository Target;
        public EmployeeDto UpdateEmployee;

        [SetUp]
        public void Setup()
        {
            Target = new EmployeeRepository();
            
            Expected = Target.Entities.vEmployees.First(x=>x.City=="seattle");
            OldFistName = Expected.FirstName;
            OldLastName = Expected.LastName;
            UpdateEmployee = new EmployeeDto
                                 {
                                     FirstName = "Joe", 
                                     LastName = "Bob",
                                     Id = Expected.BusinessEntityID
                                 };
            Target.UpdateEmployee(UpdateEmployee);
            Actual = Target.Entities.vEmployees.Single(x => x.BusinessEntityID == Expected.BusinessEntityID);
        }

        [TearDown]
        public void Teardown()
        {
            var revertEmployee = Target.Entities.Employees.Single(x => x.BusinessEntityID == Expected.BusinessEntityID);
            revertEmployee.Person.FirstName = OldFistName;
            revertEmployee.Person.LastName = OldLastName;
            Target.Entities.SaveChanges();
        }

        [Test]
        public void Updated_FirstName_Test()
        {
            Assert.AreEqual(UpdateEmployee.FirstName, Actual.FirstName);
        }

        [Test]
        public void Updated_LastName_Test()
        {
            Assert.AreEqual(UpdateEmployee.LastName, Actual.LastName);
        }
    }
}