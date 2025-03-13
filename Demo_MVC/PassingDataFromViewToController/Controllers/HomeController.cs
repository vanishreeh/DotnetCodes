using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using PassingDataFromViewToController.Models;

namespace PassingDataFromViewToController.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    #region Usingparameters
    //[HttpPost]
    //using parameters
    //public IActionResult Index(int id,string name)
    //{

    //    int userId = id;
    //    string userName = name;
    //    StringBuilder sb = new StringBuilder();
    //    sb.Append(userId);
    //    sb.Append(userName);
    //    return Content(sb.ToString());

    //    //return View();
    //}
    #endregion
    #region Strongly Binding with Model
    //[HttpPost]
    //public IActionResult Index(Product product)
    //{
    //    return View();
    //}
    #endregion
    [HttpPost]
    public IActionResult Index(IFormCollection form)
    {
        int productId = int.Parse(form["Id"]);
        string productName = form["Name"];
        StringBuilder sb = new StringBuilder();
        sb.Append($"Id::{productId}");
        sb.Append($"Name::{productName}");
        return Content(sb.ToString());
        //return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
