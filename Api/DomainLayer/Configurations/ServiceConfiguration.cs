using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Image).IsRequired();
            builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(500);
        }
    }
}
