using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {
        public BannerRepository(AppDbContext context) : base(context)
        {

        }
    }
}
