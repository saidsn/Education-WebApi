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
        private readonly DbSet<CourseAuthor> _courseAuthors;

        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _course = _context.Set<Course>();
            _courseAuthors = _context.Set<CourseAuthor>();
        }

        public async Task<Course> GetWithAuthorsAndStudentsAsync(int id)
        {
            var course = await _course
              .Where(a => !a.isDeleted)
              .Include("Students")
              .AsNoTracking()
              .Include("CourseAuthors")
              .Include("CourseAuthors.Author")
              .FirstOrDefaultAsync(c => c.Id == id) ?? throw new NullReferenceException();

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

        public async Task DeleteCourseAuthor(List<CourseAuthor> courseAuthors)
        {
            foreach (var courseAuthor in courseAuthors)
            {
                _courseAuthors.Remove(courseAuthor);

                await _context.SaveChangesAsync();
            }
        }
    }
}
