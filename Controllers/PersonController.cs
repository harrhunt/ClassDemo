using Microsoft.AspNetCore.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers 
{
    public class PersonController : Controller {
        public IActionResult Index() {
            // ViewBag.Pizza = "Pepperoni";
            // ViewData["IceCream"] = "Chocolate";
            DAL d = new DAL();
            return View(d.GetPeople());
        }

        public IActionResult Details() {
            Person p = new Person();
            p.FirstName = "Hunter";
            p.LastName = "Harris";
            p.DateOfBirth = new DateOnly(2000, 3, 9);
            p.IsManager = true;
            return View(p);
        }
    }
}