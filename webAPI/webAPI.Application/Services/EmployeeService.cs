using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;

namespace webAPI.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public void addEmployee(Employee employee)
        {
            _employeeRepository.AddEmployees(employee);
        }

        public EmployeeViewModel GetEmployee()
        {
            return new EmployeeViewModel()
            {
                employees = _employeeRepository.GetEmployees()
            };
        }

        public EmployeeViewModel GetEmployeeByLevel()
        {
            return new EmployeeViewModel()
            {
                employees = _employeeRepository.GetEmployeesByLevel()
            };
        }
    }
}
