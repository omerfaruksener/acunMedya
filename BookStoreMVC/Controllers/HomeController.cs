using Microsoft.AspNetCore.Mvc;

namespace BookStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hoşgeldiniz - Book Store";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Hakkımızda";
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
