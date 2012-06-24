using System.Collections.Generic;
using System.Linq;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private adventureworksEntities  _entities;
        public adventureworksEntities Entities
        {
            get { return _entities ?? (_entities = new adventureworksEntities()); }
            set { _entities = value; }
        }

        public IList<EmployeeDto> GetEmployeeByCityState(string city, string state)
        {
            var result = Entities.vEmployees
                .Where(x => x.City == city && x.StateProvinceName == state)
                .Select(x => new EmployeeDto {City = x.City, State = x.StateProvinceName, EmployeeName = x.FirstName});
            return result.ToList();
        }

        public bool UpdateEmployee(EmployeeDto updateEmployee)
        {
            throw new System.NotImplementedException();
        }
    }
}