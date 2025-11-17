using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCatalog.Models;

namespace WebCatalog.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.ToTable("Users");
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Id)
                  .ValueGeneratedNever();
            entity.Property(u => u.Name)
                  .IsRequired()
                  .HasMaxLength(100);
            entity.Property(u => u.Email)
                  .IsRequired()
                  .HasMaxLength(100);
            entity.HasIndex(u => u.Email)
                  .IsUnique();
            entity.Property(u => u.PasswordHash)
                  .IsRequired();
            entity.Property(u => u.Salt)
                  .IsRequired();
            entity.Property(u => u.Role)
                  .IsRequired()
                  .HasConversion<string>()
                  .HasMaxLength(20);
            entity.Property(u => u.CreatedAt)
                  .IsRequired();
        }
    }
}
