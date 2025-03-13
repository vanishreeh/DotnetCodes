using Microsoft.AspNetCore.Mvc;
using MVCCoreProductAppWithList.Models;
using MVCCoreProductAppWithList.Repository;

namespace MVCCoreProductAppWithList.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;
        //constructor level dependency injection
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult GetProducts()
        {
            List<Product>allProducts= _productRepository.GetProducts();
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return View();
            //return RedirectToAction("GetProducts");
        }
        [HttpGet]
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var product = _productRepository.GetProductById(id);
            
            _productRepository.Delete(id);
            //return View(product);
          return RedirectToAction("GetProducts");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productRepository.GetProductById(id);
            return View(product);
        }
        public IActionResult Edit(Product product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("GetProducts");

        }
    }
}
