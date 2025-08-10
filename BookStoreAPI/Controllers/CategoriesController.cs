using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _db.Categories.Include(c => c.Books).ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cat = await _db.Categories.Include(c => c.Books).FirstOrDefaultAsync(c => c.Id == id);
            if (cat == null) return NotFound();
            return Ok(cat);
        }
    }
}
