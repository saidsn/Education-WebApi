using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<List<Author>> GetAllAuthor();
        Task CreateAuthor(Author author);
    }
}
