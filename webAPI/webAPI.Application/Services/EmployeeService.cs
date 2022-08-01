using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }
        public EmployeeViewModel GetEmployee()
        {
            return new EmployeeViewModel()
            {
                employees = _employeeRepository.GetEmployees()
            };
        }
    }
}
