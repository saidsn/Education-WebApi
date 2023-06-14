using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;


namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Course> _course;

        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _course = _context.Set<Course>();
        }

        public async Task<Course> GetWithAuthorsAndStudentsAsync(int id)
        {
            var course = await _course
              .Where(a => !a.isDeleted)
              .Include("Students")
              .Include("CourseAuthors")
              .Include("CourseAuthors.Author")
              .FirstOrDefaultAsync(c => c.Id == id);

            return course;
        }


        public async Task<List<Course>> GetAllWithAuthorsAndStudentsAsync()
        {
            var courses = await _course
                 .Where(c => !c.isDeleted)
                 .Include("Students")
                 .Include("CourseAuthors")
                 .Include("CourseAuthors.Author")
                 .ToListAsync();
            return courses;
        }
    }
}
