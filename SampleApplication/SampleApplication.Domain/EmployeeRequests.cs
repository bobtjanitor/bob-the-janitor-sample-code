using System;
using System.Collections.Generic;
using SampleApplication.Objects.Dvrs;
using SampleApplication.Repository;

namespace SampleApplication.Domain
{
    public class EmployeeRequests
    {
        private IList<string> _errors = new List<string>();
        private IEmployeeRepository _employeeRepository;

        public IList<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        public IEmployeeRepository EmployeeRepository
        {
            get {
                if (_employeeRepository==null)
                {
                    _employeeRepository = Factory.GetEmployeeRepository();
                }
                return _employeeRepository;
            }
            set {
                _employeeRepository = value;
            }
        }

        public IList<EmployeeDvr> GetEmployeeByLocation(string city, string state)
        {
            List<EmployeeDvr> employees = new List<EmployeeDvr>();

            if (string.IsNullOrWhiteSpace(city))
            {
                Errors.Add("Invalid City");
            }

            if (string.IsNullOrWhiteSpace(state))
            {
                Errors.Add("Invalid State");
            }

            return employees;
        }
    }
}
