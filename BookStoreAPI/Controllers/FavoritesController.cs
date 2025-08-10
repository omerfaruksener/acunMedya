using Microsoft.AspNetCore.Mvc;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public FavoritesController(AppDbContext db) => _db = db;

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Favorite fav)
        {
            fav.AddedAt = DateTime.UtcNow;
            _db.Favorites.Add(fav);
            await _db.SaveChangesAsync();
            return Ok(fav);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetForUser(string userId)
        {
            var list = _db.Favorites.Where(f => f.UserId == userId).ToList();
            return Ok(list);
        }
    }
}
