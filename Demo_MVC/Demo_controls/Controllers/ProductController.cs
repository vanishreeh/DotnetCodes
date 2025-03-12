using Demo_controls.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_controls.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            //return View(product);
            else
            {
                return Content($"Product name::{product.Name}");
            }
                
        }
    }
}
