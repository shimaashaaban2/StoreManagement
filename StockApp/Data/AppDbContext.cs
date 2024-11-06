using Microsoft.EntityFrameworkCore;
using StockApp.Models;

namespace StockApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Store>().ToTable("Stores");
            modelBuilder.Entity<Purchase>().ToTable("Purchase");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
