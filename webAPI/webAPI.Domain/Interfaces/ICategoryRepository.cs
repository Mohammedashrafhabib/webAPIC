using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Product_Category> GetCategories();
    }
}
