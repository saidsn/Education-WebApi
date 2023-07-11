using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Author> _author;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _author = _context.Set<Author>();
        }
    }
}
