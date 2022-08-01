using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeViewModel GetEmployee();
        void addEmployee(Employee employee);
        EmployeeViewModel GetEmployeeByLevel();
    }
}
