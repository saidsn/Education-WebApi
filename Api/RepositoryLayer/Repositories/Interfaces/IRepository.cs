using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}
