using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public string Details()
        {
            return "Welcome!";
        }
        public string detailsWithId(int id)
        {
            return $"Welcome! Your ID is {id}";
        }

    }
}
