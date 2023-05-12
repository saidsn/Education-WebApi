using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        //private readonly AppDbContext _context;
        //private readonly DbSet<Title> _title;

        public TitleRepository(AppDbContext context) : base(context)
        {
            //_context = context;
            //_title = _context.Set<Title>();
        }

        //public async Task<bool> IsExsist(Expression<Func<Title, bool>> expression)
        //{
        //    return await _title.AnyAsync(expression);
        //}
    }
}
