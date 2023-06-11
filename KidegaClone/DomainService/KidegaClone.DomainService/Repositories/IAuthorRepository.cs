using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetByName(string name);
        Task<IEnumerable<Author>> GetByNameAsync(string name);
        IEnumerable<Author> GetBySurname(string surname);        
        Task<IEnumerable<Author>> GetBySurnameAsync(string surname);
    }

}
