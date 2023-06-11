using KidegaClone.Domain;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T? Get(int id);
        Task<T?> GetAsync(int id);
        IList<T?> GetAll();
        Task<IList<T?>> GetAllAsync();
        IList<T> GetAllWithPredicate(Expression<Func<T, bool>> predicate);
        Task<IList<T>> GetAllWithPredicateAsync(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        Task CreateAsync(T entity);
        void Delete(int id);
        Task DeleteAsync(int id);
        void Update(T entity);
        Task UpdateAsync(T entity);
        bool IsExist(int id);
        Task<bool> IsExistsAsync(int id);
    }
}
