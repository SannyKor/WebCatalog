using Microsoft.EntityFrameworkCore;
using WebCatalog.Data.Configurations;
using WebCatalog.Models;

namespace WebCatalog.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext (DbContextOptions<CatalogDbContext> options) : base(options) { }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<QuantityHistoryLog> QuantityHistories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogDbContext).Assembly);
        }

    }
}
