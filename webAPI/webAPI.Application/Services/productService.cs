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
    public class productService : IproductService
    {
        private IproductRepository _productRepository;
        public productService(IproductRepository repository)
        {
            _productRepository = repository;
        }
        public productViewModel GetProducts()
        {
            return new productViewModel()
            {
                products = _productRepository.GetProducts()
            };
        }
    }
}
