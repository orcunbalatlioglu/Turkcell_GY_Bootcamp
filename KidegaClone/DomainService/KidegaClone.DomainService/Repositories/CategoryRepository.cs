using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly KidegaCloneDbContext _context;

        public CategoryRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Category entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Categories.Find(id);
            _context.Categories.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Category entity)
        {
            _context.Categories.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Category? Get(int id)
        {
            return _context.Categories.SingleOrDefault(x => x.Id == id);
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await _context.Categories.SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Category?> GetAll()
        {
            return _context.Categories.AsNoTracking().ToList();
        }

        public async Task<IList<Category?>> GetAllAsync()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }

        public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
        {
            return _context.Categories.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Category>> GetAllWithPredicateAsync(Expression<Func<Category, bool>> predicate)
        {
            return await _context.Categories.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Categories.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Category> GetByBook(Book book)
        {
            return _context.Categories.Where(b => b.Books.Any(c => c.Book == book)).AsEnumerable();
        }

        public async Task<IEnumerable<Category>> GetByBookAsync(Book book)
        {
            return await _context.Categories.Where(b => b.Books.Any(c => c.Book == book)).ToListAsync();
        }

        public IEnumerable<Category> GetByBookID(int bookId)
        {
            return _context.Categories.Where(b => b.Books.Any(c => c.BookID == bookId)).AsEnumerable();
        }
        
        public async Task<IEnumerable<Category>> GetByBookIDAsync(int bookId)
        {
            return await _context.Categories.Where(b => b.Books.Any(c => c.BookID == bookId)).ToListAsync();
        }
    }
}
