using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ActionReturnTypes.Models;
using Microsoft.Extensions.Caching.Memory;

namespace ActionReturnTypes.Controllers;

public class HomeController : Controller
{
    private readonly IMemoryCache _cache;
    #region 

    //public string Index()
    //{
    //    return "Returning Primitive Types";
    //}

    //public IActionResult Privacy()
    //{
    //    return View();
    //}
    //public ActionResult Home()
    //{
    //    return View();
    //}
    ////ActionResult<T>
    //public ActionResult<Product> GetProduct(int id)
    //{
    //    Product product = new Product { Id = 1, Name = "TV" };
    //    return product;
    //}
    ////JsonResult
    //public  JsonResult GetData()
    //{
    //    var product = new Product { Id = 1, Name = "Laptop" };
    //    return Json(product);
    //}
    //public ViewResult GetViewResult()
    //{
    //    var product = new Product { Id = 1, Name = "Laptop" };
    //    return View(product);
    //}
    //public IActionResult RedirectMethod()
    //{
    //    return Redirect("https://www.google.com");
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
    #endregion
    //constructor
    public HomeController(IMemoryCache cache)
    {
        _cache = cache;
    }

    public IActionResult GetProducts()
    {
        string key = "products";
        if(!_cache.TryGetValue(key, out string product))
        {
            //call the db
            product = "HeadPhone";
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                SlidingExpiration = TimeSpan.FromMinutes(5)
            };
            _cache.Set(key, product, cacheOptions);
        }
        return View();
    }
}
