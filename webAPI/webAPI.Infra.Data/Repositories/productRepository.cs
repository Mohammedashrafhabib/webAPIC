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
    public class ProductRepository : IProductRepository
    {
        private CompanyDBContext _ctx;
        public ProductRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _ctx.products;
        }
    }
}
