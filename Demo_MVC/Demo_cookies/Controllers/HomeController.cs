using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_cookies.Models;

namespace Demo_cookies.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(User user)
    {
        CookieOptions options = new CookieOptions();
        options.Expires = DateTime.Now.AddMinutes(10);
        Response.Cookies.Append("Name", $"{user.UserName}");
        return RedirectToAction("DashBoard");

    }

    public IActionResult DashBoard()
    {
       ViewBag.UserName= Request.Cookies["Name"];
        return View();
    }


}
