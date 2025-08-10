namespace BookStoreMVC.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto? Category { get; set; }
    }

    public class CategoryDto { public int Id { get; set; } public string Name { get; set; } = null!; }
}
