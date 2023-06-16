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


        public async Task<Student> GetWithCoursesAsync(int id)
        {
            var student = await _student
                .Where(a => !a.isDeleted)
                .Include("Course")
                .FirstOrDefaultAsync(s => s.Id == id) ?? throw new NullReferenceException();

            return student;
        }


        public async Task<List<Student>> GetAllWithCoursesAsync()
        {
            var students = await _student
                .Where(a => !a.isDeleted)
                .Include("Course")
                .ToListAsync();

            return students;
        }
    }
}
