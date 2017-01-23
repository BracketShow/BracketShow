using Microsoft.AspNetCore.Mvc;
using Models.HomeViewModels;

namespace BracketShow.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            return View(new IndexViewModel(id));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
