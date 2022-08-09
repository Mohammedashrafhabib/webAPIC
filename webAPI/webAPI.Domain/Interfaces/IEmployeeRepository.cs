using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
      
        IEnumerable<Employee> GetEmployeesByLevel();
    }
}
