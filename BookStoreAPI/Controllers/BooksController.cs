using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public BooksController(AppDbContext db, IWebHostEnvironment env) { _db = db; _env = env; }

        // Public: list all books (with category)
        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _db.Books.Include(b => b.Category).ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _db.Books.Include(b => b.Category).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // Admin: create book (multipart/form-data with optional image)
        [HttpPost("admin")]
        public async Task<IActionResult> Create([FromForm] string title, [FromForm] decimal price, [FromForm] int categoryId, [FromForm] IFormFile? image)
        {
            string? imageUrl = null;
            if (image != null && image.Length > 0)
            {
                var uploads = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
                Directory.CreateDirectory(uploads);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using var fs = System.IO.File.Create(filePath);
                await image.CopyToAsync(fs);
                imageUrl = "/uploads/" + fileName;
            }

            var book = new Book { Title = title, Price = price, CategoryId = categoryId, ImageUrl = imageUrl };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        // Admin: update
        [HttpPut("admin/{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] string title, [FromForm] decimal price, [FromForm] int categoryId, [FromForm] IFormFile? image)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null) return NotFound();

            if (image != null && image.Length > 0)
            {
                var uploads = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
                Directory.CreateDirectory(uploads);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using var fs = System.IO.File.Create(filePath);
                await image.CopyToAsync(fs);
                book.ImageUrl = "/uploads/" + fileName;
            }

            book.Title = title;
            book.Price = price;
            book.CategoryId = categoryId;

            await _db.SaveChangesAsync();
            return NoContent();
        }

        // Admin: delete
        [HttpDelete("admin/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null) return NotFound();
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
