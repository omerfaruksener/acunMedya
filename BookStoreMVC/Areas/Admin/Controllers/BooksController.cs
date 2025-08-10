using Microsoft.AspNetCore.Mvc;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public BooksController(AppDbContext db, IWebHostEnvironment env) { _db = db; _env = env; }

        public IActionResult Index()
        {
            var books = _db.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book, IFormFile? image)
        {
            if (!ModelState.IsValid) { ViewBag.Categories = _db.Categories.ToList(); return View(book); }
            if (image != null)
            {
                var uploads = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
                Directory.CreateDirectory(uploads);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using var fs = System.IO.File.Create(filePath);
                await image.CopyToAsync(fs);
                book.ImageUrl = "/uploads/" + fileName;
            }
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var book = _db.Books.Find(id);
            if (book == null) return NotFound();
            ViewBag.Categories = _db.Categories.ToList();
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Book updated, IFormFile? image)
        {
            var book = _db.Books.Find(id);
            if (book == null) return NotFound();
            if (image != null)
            {
                var uploads = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
                Directory.CreateDirectory(uploads);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using var fs = System.IO.File.Create(filePath);
                await image.CopyToAsync(fs);
                book.ImageUrl = "/uploads/" + fileName;
            }
            book.Title = updated.Title;
            book.Price = updated.Price;
            book.CategoryId = updated.CategoryId;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var book = _db.Books.Find(id);
            if (book == null) return NotFound();
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
