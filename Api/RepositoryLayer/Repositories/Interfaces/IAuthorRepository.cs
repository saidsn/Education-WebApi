using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetWithCoursesAsync(int id);
    }
}
