using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookStoreMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cartJson = HttpContext.Session.GetString("cart") ?? "[]";
            ViewBag.CartJson = cartJson;
            return View();
        }

        [HttpPost]
        public IActionResult Add(int bookId)
        {
            var cartJson = HttpContext.Session.GetString("cart") ?? "[]";
            var list = JsonConvert.DeserializeObject<List<int>>(cartJson) ?? new List<int>();
            list.Add(bookId);
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list));
            TempData["Message"] = "Sepete eklendi";
            return RedirectToAction("Index","Books");
        }
    }
}
