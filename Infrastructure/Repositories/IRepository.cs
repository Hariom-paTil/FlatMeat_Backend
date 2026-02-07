using System.Linq.Expressions;

namespace FlatMeat_Backend.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {

        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task SaveAsync();
    }
}
