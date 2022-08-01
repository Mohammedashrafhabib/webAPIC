using webAPI.Domain.Models;

namespace webAPI.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> employees { get; set; }
    }
}
