using Microsoft.AspNetCore.Mvc;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;
using System.Threading;
namespace webAPI.Mvc.Controllers
{
    [ApiController]
    //[Route("webAPI.Mvc/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private readonly static Semaphore _semaphore=new Semaphore(1,1);

        public EmployeeController(IEmployeeService iemployeeService)
        {
            _employeeService = iemployeeService;

        }


        [HttpGet]
        [Route("/getemployee")]
        public IActionResult Index()
        {
            
            _semaphore.WaitOne();
            EmployeeViewModel model = _employeeService.GetEmployeeByLevel();
            _semaphore.Release();
            //EmployeeViewModel model1 = _employeeService.GetEmployee();
            //EmployeeViewModel model2 = _employeeService.GetEmployee();
            //model.employees = (from e in model1.employees
            //                   join e1 in model2.employees on e.ReprotsTo equals e1.Id into x
            //                   from data_B in x.DefaultIfEmpty(new Employee { ReprotsTo = 0 })
            //                   select new Employee
            //                   {
            //                       Id = e.Id,
            //                       Name = e.Name,
            //                       ReprotsTo = data_B.ReprotsTo

            //                   }).Concat(model1.employees)
            //                 ;

            //model.employees = from e in model.employees
            //                  where (e.Id != 2 && e.ReprotsTo != 0) || e.Id == 2
            //                  select e;
            return View(model);
        }
        //[HttpPost]
        //[Route("/addemployee")]
        //public IActionResult Index(int reptts, string name)
        //{
        //    Employee employee = new Employee { ReprotsTo = reptts, Name = name };
        //    _employeeService.addEmployee(employee);
        //    return View();
        //}
    }
}

