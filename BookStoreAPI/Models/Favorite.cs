namespace BookStoreAPI.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int BookId { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
