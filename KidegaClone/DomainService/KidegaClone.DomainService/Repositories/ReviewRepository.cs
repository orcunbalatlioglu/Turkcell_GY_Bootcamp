using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly KidegaCloneDbContext  _context;

        public ReviewRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Review entity)
        {
            _context.Reviews.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Review entity)
        {
            await _context.Reviews.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Reviews.Find(id);
            _context.Reviews.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Review entity)
        {
            _context.Reviews.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Review entity)
        {
            _context.Reviews.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Review? Get(int id)
        {
            return _context.Reviews.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public async Task<Review?> GetAsync(int id)
        {
            return await _context.Reviews.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Review?> GetAll()
        {
            return _context.Reviews.AsNoTracking().ToList();
        }

        public async Task<IList<Review?>> GetAllAsync()
        {
            return await _context.Reviews.AsNoTracking().ToListAsync();
        }

        public IList<Review> GetAllWithPredicate(Expression<Func<Review, bool>> predicate)
        {
            return _context.Reviews.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Review>> GetAllWithPredicateAsync(Expression<Func<Review, bool>> predicate)
        {
            return await _context.Reviews.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Reviews.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Reviews.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Review> GetByBook(Book book)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.Book == book).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByBookAsync(Book book)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.Book == book).ToListAsync();
        }

        public IEnumerable<Review> GetByBookID(int bookID)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.Book.Id == bookID).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByBookIDAsync(int bookID)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.Book.Id == bookID).ToListAsync();
        }

        public IEnumerable<Review> GetByRating(decimal rating)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.Rating == rating).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByRatingAsync(decimal rating)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.Rating == rating).ToListAsync();
        }

        public IEnumerable<Review> GetByUser(User user)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.User == user).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByUserAsync(User user)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.User == user).ToListAsync();
        }

        public IEnumerable<Review> GetByUserID(int userID)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.User.Id == userID).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByUserIDAsync(int userID)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.User.Id == userID).ToListAsync();
        }

        public IEnumerable<Review> GetByComment(string comment)
        {
            return _context.Reviews.AsNoTracking().Where(r=> r.Comment == comment).AsEnumerable();
        }

        public IEnumerable<Review> GetByTitle(string title)
        {
            return _context.Reviews.AsNoTracking().Where(r => r.Title == title).AsEnumerable();
        }

        public async Task<IEnumerable<Review>> GetByCommentAsync(string comment)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.Comment == comment).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetByTitleAsync(string title)
        {
            return await _context.Reviews.AsNoTracking().Where(r => r.Title == title).ToListAsync();
        }
    }
}
