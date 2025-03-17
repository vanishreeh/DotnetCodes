using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookAPPWithdatabase.Models;

namespace BookAPPWithdatabase.Controllers;
//[Route("[controller]/[action]")]
//[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //[Route("")]
    //[Route("Home")]
    //[Route("Home/Index")]
    [Route("Index")]
    public IActionResult Index()
    {
        return View();
    }
    [Route("")]
    [Route("privacy")]
    public IActionResult Privacy()
    {
        return View();
    }
    //[HttpGet("{id}")]//Home/Update/{id}
    //public IActionResult Update()
    //{
    //    return View();
    //}
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
