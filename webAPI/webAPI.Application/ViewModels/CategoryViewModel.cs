using webAPI.Domain.Models;

namespace webAPI.Application.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<Product_Category> categories { get; set; }
    }
}
