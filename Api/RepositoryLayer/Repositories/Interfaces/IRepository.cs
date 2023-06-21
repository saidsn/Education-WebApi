using DomainLayer.Common;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        Task Delete(T entity);
        Task SoftDelete(T entity);
        Task Update(T entity);
        Task<List<T>> FindAll(Expression<Func<T, bool>> expression);
        Task<bool> IsExsist(Expression<Func<T, bool>> expression);
        Task DeleteList(List<T> entities);
    }
}
