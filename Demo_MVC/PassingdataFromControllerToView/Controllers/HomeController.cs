using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PassingdataFromControllerToView.Models;

namespace PassingdataFromControllerToView.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        #region viewData ViewBag ViewModel
        //ViewData["data"] = "data is from View Data";
        //List<Product> products = new List<Product>
        //{
        //    new Product{Id=1,Name="TV"},
        //     new Product{Id=2,Name="laptop"},
        //};
        //ViewData["products"] = products;
        //ViewBag.data = "data is from viewBag";
        //ViewBag.productsList = products;
        //var product = new Product()
        //{
        //    Id = 1,
        //    Name = "TV"
        //};
        //return View(product);
        #endregion
        TempData["Name"] = "Vanishree";
        return View();

    }

    public IActionResult Privacy()
    {
        ViewBag.Name = TempData["Name"];
        TempData.Peek("Name");
        
        return View();
    }
    public IActionResult Contact()
    {
        ViewBag.Name = TempData["Name"];
        TempData.Keep("Name");
        return View();
    }
    public IActionResult AboutUs()
    {
        ViewBag.Name = TempData["Name"];
        return View();
    }


}
