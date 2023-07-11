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
    }
}
