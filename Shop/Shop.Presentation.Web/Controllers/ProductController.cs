using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.BusinessLogic.Models;
using Shop.BusinessLogic.Services.Interfaces;

namespace Shop.Presentation.Web.Controllers
{
    [Authorize]
    [Route("Product")]
    public class ProductController : Controller
    {
        private const int UserId = 1;
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll(string categoryName)
        {
            ViewBag.CategoryName = categoryName;

            var products = _productService.GetAll(categoryName);

            return View("Products", products);
        }

        [HttpGet]
        [Route("GetOrderedProducts")]
        public IActionResult GetOrderedProducts()
        {
            ViewBag.Title = "Ordered Products";

            var products = _productService.GetOrderedProducts(User.Identity.Name);

            return View("OrderedProducts", products);
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(string productName, string categoryName)
        {
            ViewBag.Title = "Product Form";
            ViewBag.CategoryName = categoryName;

            var product = _productService.Get(productName);

            return View("Product", product);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public IActionResult CreateOrUpdate(Product product, string categoryName)
        {
            ViewBag.Title = "Product Form";
            ViewBag.CategoryName = categoryName;

            if (product.Id == 0)
            {
                _productService.Create(product, categoryName);
            }
            else
            {
                _productService.Update(product);
            }

            return RedirectToAction("GetAll", new { CategoryName = categoryName });
        }

        [HttpGet]
        [Route("Buy")]
        public IActionResult Buy(int productId, string categoryName)
        {
            ViewBag.Title = "Products";
            ViewBag.CategoryName = categoryName;

            var products = _productService.GetAll(categoryName);

            _productService.Buy(productId, User.Identity.Name);

            return View("Products", products);
        }

        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(int productId, string categoryName)
        {
            _productService.Delete(productId);

            return RedirectToAction("GetAll", new { CategoryName = categoryName });
        }

        [HttpGet]
        [Route("DeleteOrderedProduct")]
        public IActionResult DeleteOrderedProduct(int productId)
        {
            _productService.DeleteOrderedProduct(productId, User.Identity.Name);

            return RedirectToAction("GetOrderedProducts");
        }

        [HttpGet]
        [Route("PayOrderedProducts")]
        public IActionResult PayOrderedProducts()
        {
            _productService.PayOrderedProducts(User.Identity.Name);

            return RedirectToAction("GetOrderedProducts");
        }
    }
}
