using Microsoft.EntityFrameworkCore;

namespace ArmandosProductShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } // Creates a table for All Categories
        public DbSet<Product> Products { get; set; } //Creates a table for All Products

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Chocolates"},
                new Category { CategoryID = 2, Name = "Fruit Candy"},
                new Category { CategoryID = 3, Name = "Gummy Candy"},
                new Category { CategoryID = 4, Name = "Halloween Candy"},
                new Category { CategoryID = 5, Name = "Hard Candy"}
                );
        }

    }
}
