using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Models;
namespace webAPI.Infra.Data.Context
{
    public class BuildingsDBContext :DbContext
    {
        public  BuildingsDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Building> buildings { get; set; }
        public DbSet<Flat> flats { get; set; }
        public DbSet<Debt> debts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}
