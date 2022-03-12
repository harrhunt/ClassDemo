using Microsoft.AspNetCore.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers 
{
    public class ThingTypeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About(string value, int number) {
            ViewBag.Number = number;
            if (value != null) {
                ViewBag.Stuff = value;
            } else {
                ViewBag.Stuff = "Nothing";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        // [HttpPost]
        // public IActionResult Create(int id, string Name, bool CanShare) {
        //     return View();
        // }

        [HttpPost]
        public IActionResult Create(ThingType thingType) {
            Console.WriteLine(thingType.ID);
            Console.WriteLine(thingType.Name);
            Console.WriteLine(thingType.CanShare);
            return View(thingType);
        }
    }
}