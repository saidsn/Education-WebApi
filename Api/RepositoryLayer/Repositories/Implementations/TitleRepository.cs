using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        public TitleRepository(AppDbContext context) : base(context)
        {

        }
    }
}
