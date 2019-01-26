using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UPOrders.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Item> Items { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
