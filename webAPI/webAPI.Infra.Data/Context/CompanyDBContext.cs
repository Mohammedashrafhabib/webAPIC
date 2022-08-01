using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Models;
namespace webAPI.Infra.Data.Context
{
    public class CompanyDBContext :DbContext
    {
        public  CompanyDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Product_Category> categories { get; set; }
    }
}
