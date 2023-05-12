using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.SoftDeleted).HasDefaultValue(false);
            builder.Property(t => t.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(t => t.UpdateDate).HasDefaultValue(DateTime.Now);
        }
    }
}
