using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;

namespace webAPI.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private IUnitOfWork _unitOfWork;
        public EmployeeService(IEmployeeRepository repository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = repository;
            _unitOfWork = unitOfWork;
        }

        public void addEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
            _unitOfWork.complete();
        }

        public EmployeeViewModel GetEmployee()
        {
            return new EmployeeViewModel()
            {
                employees = _employeeRepository.GetAll()
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
