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
    public class ProductOrderCategoryService : IProductOrderCategoryService
    {
        private IOrderRepository _ordersRepository;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        public ProductOrderCategoryService(IOrderRepository repository, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _ordersRepository = repository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public ProductOrderCategoryVeiwModel GetProduct()
        {
            return new ProductOrderCategoryVeiwModel()
            {
                products= from p in _productRepository.GetProducts()
                             join o in _ordersRepository.GetOrders()
                             on p.Id equals o.Product_Id


                             select new ProductOrderCategory()
                             {
                                 Product_Quantity = _ordersRepository.GetOrders().Where(x => x.Product_Id == p.Id).Select(x => x.Product_Quantity).Sum(),
                                 Id=p.Id,
                                 Name=p.Name
                                 ,
                                 Category = _categoryRepository.GetCategories().Where(x => x.Id == int.Parse(p.Category_Id)).Select(x => x.Category).First()
                             }

        
            };
        }
    }
}
