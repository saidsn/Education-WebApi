using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.Property(b => b.Image).IsRequired();
            builder.Property(b => b.Title).IsRequired().HasMaxLength(50);
            builder.Property(b => b.SoftDeleted).HasDefaultValue(false);
            builder.Property(b => b.isDeleted).HasDefaultValue(false);
        }
    }
}
