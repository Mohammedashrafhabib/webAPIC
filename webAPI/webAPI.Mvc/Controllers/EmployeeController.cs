using Microsoft.AspNetCore.Mvc;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Mvc.Controllers
{
    [ApiController]
    //[Route("webAPI.Mvc/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService iemployeeService)
        {
            _employeeService = iemployeeService;

        }



        //[HttpGet]
        //[Route("/getemployee")]
        //public IActionResult Index()
        //{

        //    EmployeeViewModel model = _employeeService.GetEmployee();
        //    EmployeeViewModel model1 = _employeeService.GetEmployee();
        //    EmployeeViewModel model2 = _employeeService.GetEmployee();
        //    model.employees = from e in model1.employees
        //                      join e1 in model2.employees on e.ReprotsTo equals e1.Id into x
        //                      from data_B in x.DefaultIfEmpty(new Employee { ReprotsTo=0})
        //                      select new Employee
        //                      {
        //                          Id = e.Id,
        //                          Name = e.Name,
        //                          ReprotsTo = data_B.Id

        //                      };

        //    model.employees = from e in model.employees
        //                      where (e.Id!=2 && e.ReprotsTo!=0)||e.Id==2
        //                      select e;
        //    return View(model);
        //}
        [HttpPost]
        [Route("/addemployee")]
        public IActionResult Index(int reptts, string name)
        {
            Employee employee = new Employee { ReprotsTo = reptts, Name = name };
            _employeeService.addEmployee(employee);
            return View();
        }
    }
}

