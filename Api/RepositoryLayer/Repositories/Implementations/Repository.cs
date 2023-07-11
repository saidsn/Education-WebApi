using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }


        public async Task<T> Get(int id)
        {
            return await _entities.FindAsync(id) ?? throw new NullReferenceException();
        }


        public async Task<List<T>> GetAll()
        {
            return await _entities.Where(m => !m.SoftDeleted).ToListAsync();
        }


        public async Task Create(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            await _entities.AddAsync(entity);

            await SaveAsync();
        }


        public async Task Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            _entities.Remove(entity);

            await SaveAsync();
        }


        public async Task SoftDelete(T entity)
        {
            T? model = await _entities.FirstOrDefaultAsync(e => e.Id == entity.Id) ?? throw new NullReferenceException();

            model.SoftDeleted = true;

            await SaveAsync();
        }


        public async Task Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            _entities.Update(entity);

            await _context.SaveChangesAsync();
        }


        public async Task<bool> IsExsist(Expression<Func<T, bool>> expression)
        {
            return await _entities.AnyAsync(expression);
        }


        public async Task<List<T>> FindAllExpression(Expression<Func<T, bool>> expression)
        {
            return await _entities.Where(a => !a.SoftDeleted).Where(expression).AsNoTracking().ToListAsync();
        }


        public async Task DeleteList(List<T> entities)
        {
            foreach (var entity in entities)
            {
                if (entity == null) throw new ArgumentNullException();

                _entities.Remove(entity);

                await SaveAsync();
            }
        }


        public async Task<List<T>> GetAllWithIncludes(params string[] includes)
        {
            var query = _entities.Where(e => !e.SoftDeleted).AsQueryable();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query?.Include(item);
                }
            }
            return await query.ToListAsync();
        }


        public async Task<T> GetWithIncludes(int id, params string[] includes)
        {
            var entity = await _entities.FirstOrDefaultAsync(e => e.Id == id && !e.SoftDeleted);

            if (entity == null) throw new NullReferenceException();

            var query = _entities.AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync(e => e.Id == id && !e.SoftDeleted);
        }



        public async Task<bool> SaveAsync()
        {
            try
            {
                return (await _context.SaveChangesAsync()) > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
