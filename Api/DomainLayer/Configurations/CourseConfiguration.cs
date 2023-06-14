using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Image).IsRequired();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Price).IsRequired().HasPrecision(18, 2);
        }
    }
}
