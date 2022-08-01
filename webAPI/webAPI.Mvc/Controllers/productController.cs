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
        private readonly static Semaphore _semaphore = new Semaphore(1, 1);
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
            
            _semaphore.WaitOne();

            ProductOrderCategoryVeiwModel model=_productService.GetProduct();
            _semaphore.Release();
            

            return View(model);
        }
       


    }
}


