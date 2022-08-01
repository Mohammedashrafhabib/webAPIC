using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.ViewModels;

namespace webAPI.Application.Interfaces
{
    public interface IProductOrderCategoryService
    {
        public ProductOrderCategoryVeiwModel GetProduct();
    }
}
