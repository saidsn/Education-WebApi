using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetWithCoursesAsync(int id);
        Task<List<Author>> GetAllWithCoursesAsync();
        Task DeleteCourseAuthor(List<CourseAuthor> courseAuthors);
    }
}
