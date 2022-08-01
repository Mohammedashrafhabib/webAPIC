using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                products = _productRepository.GetProducts()
            };
        }
    }
}
