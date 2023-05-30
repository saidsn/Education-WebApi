using DomainLayer.Configurations;
using Microsoft.EntityFrameworkCore;


namespace RepositoryLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new HeaderConfiguration());
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new BannerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
