using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        IEnumerable<Publisher> GetByName(string name);
        Task<IEnumerable<Publisher>> GetByNameAsync(string name);
        IEnumerable<Publisher> GetByBookId(int id);
        Task<IEnumerable<Publisher>> GetByBookIdAsync(int id);
    }
}
