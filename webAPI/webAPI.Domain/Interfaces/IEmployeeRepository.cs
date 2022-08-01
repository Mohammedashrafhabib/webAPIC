using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        void AddEmployees(Employee employee);
    }
}
