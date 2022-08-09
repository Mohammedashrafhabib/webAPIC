using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository repository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = repository;
            _unitOfWork = unitOfWork;
        }
        public CategoryViewModel GetCategories()
        {
            return new CategoryViewModel()
            {
                categories = _categoryRepository.GetAll()
            };
        }
    }
}
