using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseAuthorRepository : Repository<CourseAuthor>, ICourseAuthorRepository
    {
        public CourseAuthorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
