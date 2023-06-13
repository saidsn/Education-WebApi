using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;


namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Course> _courses;

        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _courses = _context.Set<Course>();
        }

        public async Task<List<Course>> GetAllWithAuthorsAndStudentsAsync()
        {
            var courses = await _courses
                 .Include(c => c.Students)
                 .Include(c => c.CourseAuthors)
                 .ThenInclude(c => c.Author)
                 .ToListAsync();
            return courses;
        }

        //public async Task<List<Course>> GetAllWithAuthorsAndStudentsAsync()
        //{
        //    var courses = await _courses
        //         .Include(c => c.Students)
        //         .Include("CourseAuthors")
        //         .Include("CourseAuthors.Author")
        //         .ToListAsync();
        //    return courses;
        //}

    }
}
