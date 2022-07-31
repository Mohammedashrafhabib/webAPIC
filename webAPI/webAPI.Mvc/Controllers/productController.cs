using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;

namespace webAPI.Mvc.Controllers
{
    //[Authorize]
    public class productController : Controller
    {
        private IproductService _productService;
        public productController(IproductService iproductService)
        {
            _productService = iproductService;
        }
        public IActionResult Index()
        {
            productViewModel model=_productService.GetProducts();

            return View(model);
        }
    }
}
