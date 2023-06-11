using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly KidegaCloneDbContext _context;

        public OrderRepository(KidegaCloneDbContext kidegaCloneDbContext)
        {
            _context = kidegaCloneDbContext;
        }

        public void Create(Order entity)
        {
            _context.Orders.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Order entity)
        {
            await _context.Orders.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Orders.Find(id);
            _context.Orders.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Order entity)
        {
            _context.Orders.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Order? Get(int id)
        {
            return _context.Orders.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public async Task<Order?> GetAsync(int id)
        {
            return await _context.Orders.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public IList<Order?> GetAll()
        {
            return _context.Orders.AsNoTracking().ToList();
        }

        public async Task<IList<Order?>> GetAllAsync()
        {
            return await _context.Orders.AsNoTracking().ToListAsync();
        }

        public IList<Order> GetAllWithPredicate(Expression<Func<Order, bool>> predicate)
        {
            return _context.Orders.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Order>> GetAllWithPredicateAsync(Expression<Func<Order, bool>> predicate)
        {
            return await _context.Orders.AsNoTracking().Where(predicate).ToListAsync();
        }

        public bool IsExist(int id)
        {
            return _context.Orders.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Orders.AnyAsync(c => c.Id == id);
        }

        public IEnumerable<Order> GetByAddress(Address address)
        {
            return _context.Orders.AsNoTracking().Where(o => o.Address == address).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByAddressAsync(Address address)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.Address == address).ToListAsync();
        }

        public IEnumerable<Order> GetByAddressID(int addressID)
        {
            return _context.Orders.AsNoTracking().Where(o => o.AddressID == addressID).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByAddressIDAsync(int addressID)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.AddressID == addressID).ToListAsync();
        }

        public IEnumerable<Order> GetBySuccessfullyPaid(bool isSuccessful)
        {
            return _context.Orders.AsNoTracking().Where(o => o.IsSuccesfullyPaid == isSuccessful).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetBySuccessfullyPaidAsync(bool isSuccessful)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.IsSuccesfullyPaid == isSuccessful).ToListAsync();
        }

        public IEnumerable<Order> GetByTotalPrice(int totalPrice)
        {
            return _context.Orders.AsNoTracking().Where(o => o.TotalPrice == totalPrice).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByTotalPriceAsync(int totalPrice)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.TotalPrice == totalPrice).ToListAsync();
        }

        public IEnumerable<Order> GetByUser(User user)
        {
            return _context.Orders.AsNoTracking().Where(o => o.User == user).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByUserAsync(User user)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.User == user).ToListAsync();
        }

        public IEnumerable<Order> GetByUserID(int userID)
        {
            return _context.Orders.AsNoTracking().Where(o => o.UserID == userID).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByUserIDAsync(int userID)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.UserID == userID).ToListAsync();
        }

        public IEnumerable<Order> GetByBookId(int bookId)
        {
            return _context.Orders.AsNoTracking().Where(o => o.Books.Any(b=> b.BookID == bookId)).AsEnumerable();
        }

        public async Task<IEnumerable<Order>> GetByBookIdAsync(int bookId)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.Books.Any(b => b.BookID == bookId)).ToListAsync();
        }
    }
}
