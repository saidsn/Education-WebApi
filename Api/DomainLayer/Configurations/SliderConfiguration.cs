using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(s => s.Image).IsRequired();
            builder.Property(s => s.Title).IsRequired().HasMaxLength(300);
            builder.Property(s => s.SoftDeleted).HasDefaultValue(false);
            builder.Property(s => s.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(s => s.UpdateDate).HasDefaultValue(DateTime.Now);

        }
    }
}
