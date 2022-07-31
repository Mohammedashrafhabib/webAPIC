using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class productRepository : IproductRepository
    {
        private CompanyDBContext _ctx;
        public productRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<product> GetProducts()
        {
            return _ctx.products;
        }
    }
}
