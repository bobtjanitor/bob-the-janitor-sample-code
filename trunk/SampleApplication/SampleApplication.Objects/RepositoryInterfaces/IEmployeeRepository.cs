using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Objects.Dvrs;

namespace SampleApplication.Repository
{
    public interface IEmployeeRepository
    {
        IList<EmployeeDvr> GetEmployeeByCityState(string city, string state);
    }
}
