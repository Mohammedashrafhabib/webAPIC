using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;

namespace webAPI.Mvc.Controllers
{
    //[Authorize]
    [ApiController]
    public class productController : Controller
    {
        private IProductOrderCategoryService _productService;
       
        public productController(IProductOrderCategoryService productOrderCategoryService)
        {
            _productService = productOrderCategoryService;
           
        }
        /// <summary>
        ///  bbjb.
        /// </summary>
        /// 
        /// <returns>kmk</returns>
        [HttpGet]
        [Route("/get")]
        public IActionResult Index()
        {
            ProductOrderCategoryVeiwModel model=_productService.GetProduct();
            
            

            return View(model);
        }
       


    }
}


