using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;

namespace KidegaClone.DomainService.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetByName(string name);
        IEnumerable<User> GetBySurname(string surname);
        User? GetByEmail(string email);
        IEnumerable<User?> GetByPhoneNumber(string phoneNo);
        IEnumerable<User> GetByRole(Role role);
        Task<IEnumerable<User>> GetByNameAsync(string name);
        Task<IEnumerable<User>> GetBySurnameAsync(string surname);
        Task<User?> GetByEmailAsync(string email);
        Task<IEnumerable<User>> GetByPhoneNumberAsync(string phoneNo);
        Task<IEnumerable<User>> GetByRoleAsync(Role role);
    }

}
