using Moq;
using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Repository;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public class EmployeeRequests_Context
    {
        public EmployeeRequests Target;
        public Mock<IEmployeeRepository> MockEmployeeRepository;

        [SetUp]
        public void Setup()
        {
            Context();
            Becouse();
        }

        public virtual void Context()
        {
            Target = new EmployeeRequests();
        }

        public virtual void Becouse()
        {
            
        }
    }
}