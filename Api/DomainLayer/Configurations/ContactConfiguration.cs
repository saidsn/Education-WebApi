using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Message).IsRequired().HasMaxLength(500);
        }
    }
}
