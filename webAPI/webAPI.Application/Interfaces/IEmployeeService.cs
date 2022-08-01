using webAPI.Application.ViewModels;

namespace webAPI.Application.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeViewModel GetEmployee();
    }
}
