using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{

    public interface ITitleRepository : IRepository<Title>
    {
        //Task<bool> IsExsist(Expression<Func<Title, bool>> expression);
    }
}
