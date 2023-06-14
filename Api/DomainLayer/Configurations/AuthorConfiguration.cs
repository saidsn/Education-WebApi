using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Image).IsRequired();
            builder.Property(a => a.Position).IsRequired().HasMaxLength(50);
        }
    }
}
