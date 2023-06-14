using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class CourseAuthorCongiguration : IEntityTypeConfiguration<CourseAuthor>
    {
        public void Configure(EntityTypeBuilder<CourseAuthor> builder)
        {
            builder.Property(ca => ca.CourseId).IsRequired();
            builder.Property(ca => ca.AuthorId).IsRequired();
        }
    }
}
