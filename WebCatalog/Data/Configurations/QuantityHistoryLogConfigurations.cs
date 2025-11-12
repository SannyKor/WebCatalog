using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCatalog.Models;

namespace WebCatalog.Data.Configurations
{
    public class QuantityHistoryLogConfigurations : IEntityTypeConfiguration<QuantityHistoryLog>
    {
        public void Configure (EntityTypeBuilder<QuantityHistoryLog> entity)
        {
            entity.HasKey(q => q.Id);
            entity.Property(q => q.Id)
                  .ValueGeneratedOnAdd();
            entity.Property(q => q.UserId)
                  .IsRequired();
            entity.Property(q => q.UnitId)
                  .IsRequired();
            entity.Property(q => q.DateOfChange)
                  .IsRequired(); 
            entity.Property(q => q.UserId)
                  .IsRequired();
        }
    }
}
