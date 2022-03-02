using Microsoft.AspNetCore.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers 
{
    public class PersonController : Controller {
        public IActionResult Index() {
            ViewBag.Pizza = "Pepperoni";
            ViewData["IceCream"] = "Chocolate";
            return View();
        }

        public IActionResult Details() {
            Person p = new Person();
            p.FirstName = "Hunter";
            p.LastName = "Harris";
            p.DateOfBirth = new DateOnly(2000, 3, 9);
            return View();
        }
    }
}