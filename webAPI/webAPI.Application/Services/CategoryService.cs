using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository repository)
        {
            _categoryRepository = repository;
        }
        public CategoryViewModel GetCategories()
        {
            return new CategoryViewModel()
            {
                categories = _categoryRepository.GetCategories()
            };
        }
    }
}
