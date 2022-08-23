using eda_fundamentals.Shared.Entities;

namespace eda_fundamentals.Shared.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<T?> GetByIdAsync(Guid id);
    }
}
