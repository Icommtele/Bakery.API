using Bakery.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.API.Data
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options)
        : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
