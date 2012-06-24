using SampleApplication.Objects.RepositoryInterfaces;
using SampleApplication.Repository;

namespace SampleApplication.Domain
{
    public static class Factory
    {
        public static IEmployeeRepository GetEmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }
}
