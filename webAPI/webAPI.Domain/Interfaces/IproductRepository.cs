using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<ProductOrderCategory> GetProductsOrderCategory();
    }
}
