using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication.Objects.Dvrs;

namespace SampleApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private adventureworksEntities  _entities;
        public adventureworksEntities Entities
        {
            get
            {
                if (_entities==null)
                {
                    _entities = new adventureworksEntities();
                }
                return _entities;
            }
            set { _entities = value; }
        }

        public IList<EmployeeDvr> GetEmployeeByCityState(string city, string state)
        {
            var result = Entities.vEmployees
                .Where(x => x.City == city && x.StateProvinceName == state)
                .Select(x => new EmployeeDvr() {City = x.City, State = x.StateProvinceName, EmployeeName = x.FirstName});
            return result.ToList();
        }
    }
}