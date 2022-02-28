using Microsoft.AspNetCore.Mvc;

namespace ClassDemo.Controllers 
{
    public class PersonController : Controller {
        public IActionResult Index() {
            ViewBag.Pizza = "Pepperoni";
            ViewData["IceCream"] = "Chocolate";
            return View();
        }

        public IActionResult Details() {
            ViewBag.Pizza = "Pepperoni";
            ViewData["IceCream"] = "Chocolate";
            TempData["Pizza"] = "Meat Lovers";
            return RedirectToAction("Index");
        }
    }
}