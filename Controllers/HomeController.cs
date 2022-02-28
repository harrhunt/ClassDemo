using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Hotdog()
    {
        return View();
    }

    public IActionResult Frank()
    {
        return View("Hotdog");
    }

    public IActionResult Types()
    {
        return View("ListOfTypes");
    }

    [HttpGet]
    public IActionResult Test()
    {
        Console.WriteLine("TEST");
        return Json("{'test': 'testing'}");
    }

    [HttpPost]
    public IActionResult Test(int? id)
    {
        Console.WriteLine("TEST");
        return Json("{'test': 'testing'}");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
