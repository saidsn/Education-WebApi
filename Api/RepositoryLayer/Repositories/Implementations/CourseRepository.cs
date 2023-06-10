using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;
        //private readonly DbSet<Course> _courses;
        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            //_courses = _context.Set<Course>();
        }

        //public async Task<List<Course>> GetAllCourse()
        //{
        //    return await _courses.Include(c => c.CourseAuthors).ThenInclude(c => c.Author).ToListAsync();
        //}
    }
}
