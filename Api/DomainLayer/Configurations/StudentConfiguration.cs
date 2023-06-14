using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Image).IsRequired();
            builder.Property(s => s.FullName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Age).IsRequired();
            builder.Property(s => s.Info).IsRequired().HasMaxLength(255);
            builder.Property(s => s.IsGraduated).IsRequired().HasDefaultValue(false);
            builder.Property(s => s.CourseId).IsRequired();
        }
    }
}
