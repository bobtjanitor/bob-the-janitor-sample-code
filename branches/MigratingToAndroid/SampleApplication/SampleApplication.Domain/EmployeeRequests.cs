using System.Collections.Generic;
using SampleApplication.Objects.DomainInterfaces;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain
{
    public class EmployeeRequests
    {
        public EmployeeRequests() : this(new UserDto())
        {
            
        }

        public EmployeeRequests(UserDto user)
        {
            User = user;
        }

        private IList<string> _errors = new List<string>();
        public IList<string> Errors
        {
            get { return _errors; }
            protected set { _errors = value; }
        }

        private IEmployeeRepository _employeeRepository;
        public IEmployeeRepository EmployeeRepository
        {
            get { return _employeeRepository ?? (_employeeRepository = Factory.GetEmployeeRepository()); }
            set { _employeeRepository = value; }
        }

        public UserDto User { get; set; }

        public IAuthRequests AuthRequests { get; set; }

        public IList<EmployeeDto> GetEmployeeByLocation(string city, string state)
        {
            var employees = new List<EmployeeDto>();

            if (string.IsNullOrWhiteSpace(city))
            {
                Errors.Add("Invalid City");
            }

            if (string.IsNullOrWhiteSpace(state))
            {
                Errors.Add("Invalid State");
            }
            if (Errors.Count == 0)
            {
                var result = EmployeeRepository.GetEmployeeByCityState(city, state);
                employees.AddRange(result);
            }

            return employees;
        }

        public bool UpdateEmployee(EmployeeDto updateEmployee)
        {
            var result = false;
            if(AuthRequests.UserCanUpdateEmployee(User.Id,updateEmployee.Id))
            {
                result = EmployeeRepository.UpdateEmployee(updateEmployee);
            }
            return result;
        }
    }
}
