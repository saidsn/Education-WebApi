using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseRrepository : Repository<Course>, ICourseRepository
    {
        public CourseRrepository(AppDbContext context) : base(context)
        {
        }
    }
}
