using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_SessionState.Models;

namespace Demo_SessionState.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        HttpContext.Session.SetString("Name", "vanishree");
        HttpContext.Session.SetInt32("Age",36 );
        return View();
    }

    public IActionResult GetResult()
    {
        User user = new User()
        {
            Name = HttpContext.Session.GetString("Name"),
            Age = HttpContext.Session.GetInt32("Age")
        };
        return View(user);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetQueryString(string name,int age)
    {
        User user = new User() 
        { Name=name,
        Age=age};
        return View(user);
    }

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}
