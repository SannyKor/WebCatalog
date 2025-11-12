using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCatalog.Models;


namespace WebCatalog.Data.Configurations
{
    public class UnitConfigurations : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> entity)
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Name).IsRequired().HasMaxLength(100);
            entity.Property(u => u.Description).HasMaxLength(500);
            entity.Property(u => u.Price).IsRequired();
            entity.Property(u => u.Quantity).IsRequired();
            entity.Property(u => u.AddedDate).IsRequired();
            entity.HasMany(u => u.Categories)
                  .WithMany(c => c.Units);
            entity.HasMany(u => u.QuantityHistory)
                  .WithOne()
                  .HasForeignKey(q => q.UnitId)
                  .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
