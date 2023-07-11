using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Student> _student;
        public StudentRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _student = _context.Set<Student>();
        }
    }
}
