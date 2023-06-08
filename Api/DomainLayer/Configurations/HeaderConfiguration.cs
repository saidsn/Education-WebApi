using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.Configurations
{
    public class HeaderConfiguration : IEntityTypeConfiguration<Header>
    {
        public void Configure(EntityTypeBuilder<Header> builder)
        {
            builder.Property(h => h.Image).IsRequired();
            builder.Property(h => h.Title).IsRequired().HasMaxLength(50);
            builder.Property(h => h.SoftDeleted).HasDefaultValue(false);
            builder.Property(h => h.isDeleted).HasDefaultValue(false);
        }
    }
}
