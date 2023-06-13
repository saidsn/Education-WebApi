using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Author> _authors;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _authors = _context.Set<Author>();
        }

        public async Task<List<Author>> GetAllWithCoursesAsync()
        {
            var authors = await _authors
                .Where(a => !a.isDeleted)
                .Include(a => a.CourseAuthors)
                .ThenInclude(a => a.Course)
                .ToListAsync();

            return authors;
        }
    }
}
