 using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Title).IsRequired().HasMaxLength(300);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.UpdateDate).HasDefaultValue(DateTime.Now);

        }
    }
}
