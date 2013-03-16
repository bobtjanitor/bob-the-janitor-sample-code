using System.Collections.Generic;
using SampleApplication.Objects.Dtos;

namespace SampleApplication.Objects.DomainInterfaces
{
    public interface IAuthRequests
    {
        bool UserCanUpdateEmployee(int userId, int employeeId);
    }

    public interface IEmployeeRequests
    {
        IList<EmployeeDto> GetEmployeeByLocation(string city, string state);
    }
}
