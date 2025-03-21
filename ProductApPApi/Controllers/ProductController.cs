using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApPApi.Model;
using ProductApPApi.Repository;

namespace ProductApPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [Route("getProducts")]
        [HttpGet]
        public IActionResult GetProducts()
        {
           List<Product>allProducts= _productRepository.GetProducts();
            return Ok(allProducts);
        }
        [HttpPost]
        //[Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
           bool addStatus= _productRepository.AddProduct(product);
            //return Created("api/created", addStatus);
            return CreatedAtAction("GetProducts", new { id = product.Id }, product);
           
        }

    }
}
