using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using BookStoreMVC.Models;

namespace BookStoreMVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly IHttpClientFactory _http;
        private readonly IConfiguration _config;
        public BooksController(IHttpClientFactory http, IConfiguration config) { _http = http; _config = config; }

        public async Task<IActionResult> Index()
        {
            var client = _http.CreateClient("api");
            client.BaseAddress = new Uri(_config.GetValue<string>("ApiBaseUrl"));
            var books = await client.GetFromJsonAsync<List<BookDto>>("api/books");
            return View(books ?? new List<BookDto>());
        }

        public async Task<IActionResult> Details(int id)
        {
            var client = _http.CreateClient("api");
            client.BaseAddress = new Uri(_config.GetValue<string>("ApiBaseUrl"));
            var book = await client.GetFromJsonAsync<BookDto>($"api/books/{id}");
            if (book == null) return NotFound();
            TempData["LastViewed"] = book.Title;
            return View(book);
        }
    }
}
