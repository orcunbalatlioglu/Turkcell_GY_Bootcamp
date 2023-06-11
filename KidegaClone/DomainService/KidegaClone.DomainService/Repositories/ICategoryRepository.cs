using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetByBook(Book book);
        IEnumerable<Category> GetByBookID(int bookId);
        Task<IEnumerable<Category>> GetByBookAsync(Book book);
        Task<IEnumerable<Category>> GetByBookIDAsync(int bookId);
    }
}
