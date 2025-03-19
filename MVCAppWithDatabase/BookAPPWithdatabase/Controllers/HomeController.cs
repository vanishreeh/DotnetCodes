using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Logginglogic;
using BookAPPWithdatabase.Service;
using Microsoft.AspNetCore.Authorization;
using BookAPPWithdatabase.constants;

namespace BookAPPWithdatabase.Controllers;
//[Route("[controller]/[action]")]
//[Route("[controller]")]
[ServiceFilter(typeof(CustomLogger))]
[ServiceFilter(typeof(AddResultFiler))]
//[AddHeader]
[Authorize(Roles =Role.Adminstartor)]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public ILoggerService Logger { get; set; }
    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}
    //[Route("")]
    //[Route("Home")]
    //[Route("Home/Index")]
    //[Route("Index")]
    public IActionResult Index([FromServices]ILoggerService loggerService)
    {
        Logger = loggerService;//Property injection
        Logger?.Log("Index  action is executing");

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
