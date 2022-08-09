using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>,IEmployeeRepository
    {
        private CompanyDBContext _ctx;
        public EmployeeRepository(CompanyDBContext context):base(context)
        {
            _ctx = context;
        }

      

        public IEnumerable<Employee> GetEmployeesByLevel()
        {

            var model1 = _ctx.employees.AsQueryable();
        
           // var z = model1.Select(x => x.ReprotsTo);
            var employees = (from c in model1
                            from x in model1
                            where c.ReprotsTo==x.Id&&((c.Id != 2 && x.ReprotsTo != 0)||(c.Id== 2) )
                            select new Employee { Id = c.Id,Name=c.Name, ReprotsTo=x.ReprotsTo }).AsEnumerable().Concat(model1.AsEnumerable());
            
            //foreach (var item in employees)
            //{
            //  model1=  model1.Append(new Employee { Id = item.Id, Name = item.Name, ReprotsTo = item.ReprotsTo });
            //}
          
            return (IEnumerable<Employee>)employees;
            //            var cnn = (SqlConnection)_ctx.Database.GetDbConnection();
            //            cnn.Open();
            //            var cmd = new SqlCommand(@"

            //with c as(

            //select Id,ReprotsTo,Name
            //from Employees

            //union all
            //select c.Id,Employees.ReprotsTo,c.Name
            //from c
            //join Employees
            //on c.ReprotsTo=Employees.Id
            //where (c.Id<>2 and not Employees.ReprotsTo =0)or(c.Id=2 ) 


            //)
            //select*
            //from c 
            //order by Id



            //", cnn);
            //            var rdr = cmd.ExecuteReader(CommandBehavior.Default);

            //            IEnumerable<Employee> employees = new List<Employee>();
            //            while (rdr.HasRows)
            //            {
            //                employees.Append(new Employee() { Id = (int)rdr[0], Name = (string)rdr[2], ReprotsTo = (int)rdr[1] });
            //            }
            //            rdr.Close();
            //            return employees;
        }
    }
}
