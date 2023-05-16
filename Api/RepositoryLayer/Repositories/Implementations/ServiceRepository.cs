using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(AppDbContext context) : base(context)
        {

        }
    }
}
