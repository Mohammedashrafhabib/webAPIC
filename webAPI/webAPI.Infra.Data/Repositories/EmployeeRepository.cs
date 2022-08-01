using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private CompanyDBContext _ctx;
        public EmployeeRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _ctx.employees;
        }
    }
}
