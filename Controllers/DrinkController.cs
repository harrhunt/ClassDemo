using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers;

public class DrinkController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RootBeer()
    {
        return View();
    }
}
