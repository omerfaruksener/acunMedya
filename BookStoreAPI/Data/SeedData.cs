using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Models;

namespace BookStoreAPI.Data
{
    public static class SeedData
    {
        public static async Task EnsureSeedData(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleMgr = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            await context.Database.MigrateAsync();

            if (!await roleMgr.RoleExistsAsync("admin"))
            {
                await roleMgr.CreateAsync(new IdentityRole("admin"));
            }
            if (!await roleMgr.RoleExistsAsync("user"))
            {
                await roleMgr.CreateAsync(new IdentityRole("user"));
            }

            if (await userMgr.FindByEmailAsync("admin@site.com") == null)
{
    var admin = new ApplicationUser { UserName = "admin@site.com", Email = "admin@site.com", EmailConfirmed = true };
    await userMgr.CreateAsync(admin, "Admin123!");
    await userMgr.AddToRoleAsync(admin, "admin");
}


            if (await userMgr.FindByEmailAsync("user@local") == null)
            {
                var user = new ApplicationUser { UserName = "user@local", Email = "user@local", EmailConfirmed = true };
                await userMgr.CreateAsync(user, "Password1!");
                await userMgr.AddToRoleAsync(user, "user");
            }
        }
    }
}
