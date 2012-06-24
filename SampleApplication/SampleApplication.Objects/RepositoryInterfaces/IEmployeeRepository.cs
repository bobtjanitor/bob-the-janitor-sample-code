using System.Collections.Generic;
using SampleApplication.Objects.Dtos;

namespace SampleApplication.Objects.RepositoryInterfaces
{
    public interface IEmployeeRepository
    {
        IList<EmployeeDto> GetEmployeeByCityState(string city, string state);
        bool UpdateEmployee(EmployeeDto updateEmployee);
    }
}
