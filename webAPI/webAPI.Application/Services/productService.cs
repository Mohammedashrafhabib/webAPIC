using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;

namespace webAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;
        private IProductRepository _productRepository;
        public ProductService(IUnitOfWork unitOfWork,IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
            
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                products = _productRepository.GetAll()
            };
        }
        public void AddProducts(Product product)
        {

            _productRepository.Add(product);
            _unitOfWork.complete();


        }
    }
}
