using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly KidegaCloneDbContext _context;

        public BookRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Book entity)
        {
            await _context.Books.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Books.Find(id);
            _context.Books.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Books.FindAsync(id);
            _context.Books.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Book entity)
        {
            _context.Books.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Book? Get(int id)
        {
            return _context.Books.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public async Task<Book?> GetAsync(int id)
        {
            return await _context.Books.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Book?> GetAll()
        {
            return _context.Books.AsNoTracking().ToList();
        }

        public async Task<IList<Book?>> GetAllAsync()
        {
            return await _context.Books.AsNoTracking().ToListAsync();
        }

        public IList<Book> GetAllWithPredicate(Expression<Func<Book, bool>> predicate)
        {
            return _context.Books.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Book>> GetAllWithPredicateAsync(Expression<Func<Book, bool>> predicate)
        {
            return await _context.Books.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Books.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Books.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Book> GetByAuthor(Author author)
        {
            return _context.Books.AsNoTracking().Where(b => b.Author == author).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByAuthorAsync(Author author)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Author == author).ToListAsync();
        }

        public IEnumerable<Book> GetByAuthorID(int id)
        {
            return _context.Books.AsNoTracking().Where(b => b.AuthorID == id).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByAuthorIDAsync(int id)
        {
            return await _context.Books.AsNoTracking().Where(b => b.AuthorID == id).ToListAsync();
        }

        public IEnumerable<Book> GetByBarcode(long barcode)
        {
            return _context.Books.AsNoTracking().Where(b => b.Barcode == barcode).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByBarcodeAsync(long barcode)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Barcode == barcode).ToListAsync();
        }

        public IEnumerable<Book> GetByCategory(Category category)
        {
            return _context.Books.AsNoTracking().Where(b => b.Categories.Any(c => c.Category == category)).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByCategoryAsync(Category category)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Categories.Any(c => c.Category == category)).ToListAsync();
        }

        public IEnumerable<Book> GetByCategoryID(int categoryId)
        {
            return _context.Books.AsNoTracking().Where(b => b.Categories.Any(c => c.CategoryID == categoryId)).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Categories.Any(c => c.CategoryID == categoryId)).ToListAsync();
        }

        public IEnumerable<Book> GetByCover(bool isHard)
        {
            return _context.Books.AsNoTracking().Where(b => b.IsHardcover == isHard).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByCoverAsync(bool isHard)
        {
            return await _context.Books.AsNoTracking().Where(b => b.IsHardcover == isHard).ToListAsync();
        }

        public IEnumerable<Book> GetByName(string name)
        {
            return _context.Books.AsNoTracking().Where(b => b.Name == name).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByNameAsync(string name)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Name == name).ToListAsync();
        }

        public IEnumerable<Book> GetByPublishDate(DateTime date)
        {
            return _context.Books.AsNoTracking().Where(b => b.PublishDate == date).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByPublishDateAsync(DateTime date)
        {
            return await _context.Books.AsNoTracking().Where(b => b.PublishDate == date).ToListAsync();
        }

        public IEnumerable<Book> GetByPublisher(Publisher publisher)
        {
            return _context.Books.AsNoTracking().Where(b => b.Publisher == publisher).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByPublisherAsync(Publisher publisher)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Publisher == publisher).ToListAsync();
        }

        public IEnumerable<Book> GetByPublisherID(int id)
        {
            return _context.Books.AsNoTracking().Where(b => b.PublisherID == id).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByPublisherIDAsync(int id)
        {
            return await _context.Books.AsNoTracking().Where(b => b.PublisherID == id).ToListAsync();
        }

        public IEnumerable<Book> GetByRating(decimal rating)
        {
            return _context.Books.AsNoTracking().Where(b => b.Rating == rating).AsEnumerable();
        }

        public async Task<IEnumerable<Book>> GetByRatingAsync(decimal rating)
        {
            return await _context.Books.AsNoTracking().Where(b => b.Rating == rating).ToListAsync();
        }


    }
}
