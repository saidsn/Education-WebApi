using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseRrepository : Repository<Course>, ICourseRepository
    {
        private readonly IAuthorRepository _authorRepo;
        private readonly AppDbContext _context;
        //private readonly DbSet<Course> _courses;
        public CourseRrepository(AppDbContext context, IAuthorRepository authorRepo) : base(context)
        {
            _authorRepo = authorRepo;
            _context = context;
            //_courses = _context.Set<Course>();
        }

        //public async Task<List<Course>> GetAllCourse()
        //{
        //    return await _courses.Include(c => c.CourseAuthors).ThenInclude(c => c.Author).ToListAsync();
        //}

        public async Task CreateCourse(Course course, int[] authorIds)
        {
            var authors = await _authorRepo.FindAllByExpression(a => authorIds.Contains(a.Id));

            course.CourseAuthors = new();

            foreach (var author in authors)
            {
                course.CourseAuthors.Add(new CourseAuthor
                {
                    AuthorId = author.Id,
                    CourseId = course.Id,
                });
            }

            await _context.SaveChangesAsync();
        }

    }
}
