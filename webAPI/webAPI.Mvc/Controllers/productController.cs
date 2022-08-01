using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;

namespace webAPI.Mvc.Controllers
{
    //[Authorize]
    public class productController : Controller
    {
        private IProductService _productService;
        public productController(IProductService iproductService)
        {
            _productService = iproductService;
        }
        public IActionResult Index()
        {
            ProductViewModel model=_productService.GetProducts();

            return View(model);
        }
    }
}
