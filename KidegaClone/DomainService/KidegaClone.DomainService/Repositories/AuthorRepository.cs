using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly KidegaCloneDbContext _context;

        public AuthorRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Author entity)
        {
            _context.Authors.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Author entity)
        {
            await _context.Authors.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Authors.Find(id);
            _context.Authors.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Authors.FindAsync(id);
            _context.Authors.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Author entity)
        {
            _context.Authors.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Author entity)
        {
            _context.Authors.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Author? Get(int id)
        {
            return _context.Authors.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public async Task<Author?> GetAsync(int id)
        {
            return await _context.Authors.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Author?> GetAll()
        {
            return _context.Authors.AsNoTracking().ToList();
        }

        public async Task<IList<Author?>> GetAllAsync()
        {
            return await _context.Authors.AsNoTracking().ToListAsync();
        }

        public IList<Author> GetAllWithPredicate(Expression<Func<Author, bool>> predicate)
        {
            return _context.Authors.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Author>> GetAllWithPredicateAsync(Expression<Func<Author, bool>> predicate)
        {
            return await _context.Authors.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Authors.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Authors.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Author> GetByName(string name)
        {
            return _context.Authors.AsNoTracking().Where(a => a.Name == name).AsEnumerable();
        }

        public async Task<IEnumerable<Author>> GetByNameAsync(string name)
        {
            return await _context.Authors.AsNoTracking().Where(a => a.Name == name).ToListAsync();
        }

        public IEnumerable<Author> GetBySurname(string surname)
        {
            return _context.Authors.AsNoTracking().Where(a => a.Surname == surname).AsEnumerable();
        }

        public async Task<IEnumerable<Author>> GetBySurnameAsync(string surname)
        {
            return await _context.Authors.AsNoTracking().Where(a => a.Surname == surname).ToListAsync();
        }
    }

}
