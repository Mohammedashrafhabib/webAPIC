using webAPI.Application.ViewModels;

namespace webAPI.Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetCategories();
    }
}
