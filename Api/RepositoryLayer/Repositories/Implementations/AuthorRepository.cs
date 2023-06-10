using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        //private readonly DbSet<Author> _authors;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
            //_authors = _context.Set<Author>();
        }

        //public async Task<List<Author>> GetAllAuthor()
        //{
        //    return await _authors.Include(a => a.CourseAuthors).ThenInclude(a => a.Course).ToListAsync();
        //}
    }
}
