using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class CategoryRepository : Repository<Product_Category>, ICategoryRepository
    {
        private CompanyDBContext _ctx;
        public CategoryRepository(CompanyDBContext context):base(context)
        {
            _ctx = context;
           
        }

       

        

        
    }
}
