using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Models;

namespace BookStoreAPI.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Favorite> Favorites => Set<Favorite>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "admin", NormalizedName = "ADMIN", Id = "role-admin-id" },
                new IdentityRole { Name = "user", NormalizedName = "USER", Id = "role-user-id" }
            );

            // Seed categories
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Roman" },
                new Category { Id = 2, Name = "Bilim" },
                new Category { Id = 3, Name = "Çocuk" }
            );

            // Seed books
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Deneme Kitap A", Price = 49.90m, CategoryId = 1, ImageUrl = "/images/book1.jpg" },
                new Book { Id = 2, Title = "Deneme Kitap B", Price = 29.50m, CategoryId = 2, ImageUrl = "/images/book2.jpg" }
            );
        }
    }
}
