using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class UserRepository : IUserRepository
    {
        KidegaCloneDbContext _context;

        public UserRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Users.Find(id);
            _context.Users.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Users.FindAsync(id);
            _context.Users.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return _context.Users.AsNoTracking().SingleOrDefault(u => u.Id == id);
        }

        public async Task<User?> GetAsync(int id)
        {
            return await _context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == id);
        }

        public IList<User?> GetAll()
        {
            return _context.Users.AsNoTracking().ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public IList<User> GetAllWithPredicate(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<User>> GetAllWithPredicateAsync(Expression<Func<User, bool>> predicate)
        {
            return await _context.Users.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }

        public User? GetByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Email == email);
        }

        public IEnumerable<User> GetByName(string name)
        {
            return _context.Users.AsNoTracking().Where(u => u.Name == name).AsEnumerable();
        }

        public async Task<IEnumerable<User>> GetByNameAsync(string name)
        {
            return await _context.Users.AsNoTracking().Where(u => u.Name == name).ToListAsync();
        }

        public IEnumerable<User?> GetByPhoneNumber(string phoneNo)
        {
            return _context.Users.AsNoTracking().Where(u => u.PhoneNumber == phoneNo).AsEnumerable();
        }

        public async Task<IEnumerable<User>> GetByPhoneNumberAsync(string phoneNo)
        {
            return await _context.Users.AsNoTracking().Where(u => u.PhoneNumber == phoneNo).ToListAsync();
        }

        public IEnumerable<User> GetByRole(Role role)
        {
            return _context.Users.AsNoTracking().Where(u => u.Role == role).AsEnumerable();
        }

        public async Task<IEnumerable<User>> GetByRoleAsync(Role role)
        {
            return await _context.Users.AsNoTracking().Where(u => u.Role == role).ToListAsync();
        }

        public IEnumerable<User> GetBySurname(string surname)
        {
            return _context.Users.AsNoTracking().Where(u => u.Surname == surname).AsEnumerable();
        }

        public async Task<IEnumerable<User>> GetBySurnameAsync(string surname)
        {
            return await _context.Users.AsNoTracking().Where(u => u.Surname == surname).ToListAsync();
        }

    }
}
