using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private CompanyDBContext _ctx;
        public CategoryRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Product_Category> GetCategories()
        {
            return _ctx.categories;
        }
    }
}
