using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly KidegaCloneDbContext _context;
        public PublisherRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Publisher entity)
        {
            _context.Publishers.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Publisher entity)
        {
            await _context.Publishers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Publishers.Find(id);
            _context.Publishers.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Publishers.FindAsync(id);
            _context.Publishers.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Publisher entity)
        {
            _context.Publishers.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Publisher entity)
        {
            _context.Publishers.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Publisher? Get(int id)
        {
            return _context.Publishers.SingleOrDefault(x => x.Id == id);
        }

        public async Task<Publisher?> GetAsync(int id)
        {
            return await _context.Publishers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Publisher?> GetAll()
        {
            return _context.Publishers.AsNoTracking().ToList();
        }

        public async Task<IList<Publisher?>> GetAllAsync()
        {
            return await _context.Publishers.AsNoTracking().ToListAsync();
        }

        public IList<Publisher> GetAllWithPredicate(Expression<Func<Publisher, bool>> predicate)
        {
            return _context.Publishers.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Publisher>> GetAllWithPredicateAsync(Expression<Func<Publisher, bool>> predicate)
        {
            return await _context.Publishers.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Publishers.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Publishers.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Publisher> GetByName(string name)
        {
            return _context.Publishers.AsNoTracking().Where(p => p.Name == name).AsEnumerable();
        }

        public async Task<IEnumerable<Publisher>> GetByNameAsync(string name)
        {
            return await _context.Publishers.AsNoTracking().Where(p => p.Name == name).ToListAsync();
        }

        public IEnumerable<Publisher> GetByBookId(int bookId) 
        { 
            return _context.Publishers.AsNoTracking().Where(p => p.Books.Any(b => b.Id == bookId)).AsEnumerable();
        }

        public async Task<IEnumerable<Publisher>> GetByBookIdAsync(int bookId)
        {
            return await _context.Publishers.AsNoTracking().Where(p => p.Books.Any(b => b.Id == bookId)).ToListAsync();
        }
    }
}
