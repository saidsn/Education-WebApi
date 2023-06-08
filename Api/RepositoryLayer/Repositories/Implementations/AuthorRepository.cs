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
        private readonly DbSet<Course> _courses;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _authors = _context.Set<Author>();
            _courses = _context.Set<Course>();
        }

        public async Task CreateAuthor(Author author)
        {

        }


        public async Task<List<Author>> GetAllAuthor()
        {
            return await _authors.Include(a => a.CourseAuthors).ThenInclude(a => a.Course).ToListAsync();
        }
    }
}
