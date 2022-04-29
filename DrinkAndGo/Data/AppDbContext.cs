using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkAndGo.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopingCartItem> ShopingCartItems { get; set; }

    }
}
