using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class HeaderRepository : Repository<Header>, IHeaderRepository
    {
        public HeaderRepository(AppDbContext context) : base(context)
        {

        }
    }
}
