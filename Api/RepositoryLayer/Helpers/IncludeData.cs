using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RepositoryLayer.Helpers
{
    public static class IncludeData
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T : BaseEntity
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
