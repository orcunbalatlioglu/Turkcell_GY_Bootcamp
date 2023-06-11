using KidegaClone.DomainService.Data;
using KidegaClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KidegaClone.DomainService.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly KidegaCloneDbContext _context;
        public AddressRepository(KidegaCloneDbContext kidegaCloneDbContext) 
        { 
            _context = kidegaCloneDbContext;
        }

        public void Create(Address entity)
        {
            _context.Addresses.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Address entity)
        {
            await _context.Addresses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Addresses.Find(id);
            _context.Addresses.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Addresses.FindAsync(id);
            _context.Addresses.Remove(deleting);
            await _context.SaveChangesAsync();

        }

        public void Update(Address entity)
        {
            _context.Addresses.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Address entity)
        {
            _context.Addresses.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool IsExist(int id)
        {
            return  _context.Addresses.Any(c => c.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _context.Addresses.AnyAsync(c => c.Id == id);
        }

        public Address? Get(int id)
        {
            return _context.Addresses.SingleOrDefault(x => x.Id == id);
        }

        public async Task<Address?> GetAsync(int id)
        {
            return await _context.Addresses.SingleOrDefaultAsync(c=> c.Id == id);
        }

        public IList<Address?> GetAll()
        {
            return _context.Addresses.AsNoTracking().ToList();
        }

        public async Task<IList<Address?>> GetAllAsync()
        {
            return await _context.Addresses.AsNoTracking().ToListAsync();
        }

        public IList<Address> GetAllWithPredicate(Expression<Func<Address, bool>> predicate)
        {
            return _context.Addresses.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IList<Address>> GetAllWithPredicateAsync(Expression<Func<Address, bool>> predicate)
        {
            return await _context.Addresses.AsNoTracking().Where(predicate).ToListAsync();
        }

        public IEnumerable<Address> GetByCity(string city)
        {
            return _context.Addresses.AsNoTracking().Where(a=> a.City == city).AsEnumerable();
        }

        public async Task<IEnumerable<Address>> GetByCityAsync(string city)
        {
            return await _context.Addresses.AsNoTracking().Where(a => a.City == city).ToListAsync();
        }

        public IEnumerable<Address> GetByDistrict(string district)
        {
            return _context.Addresses.AsNoTracking().Where(a => a.District == district).AsEnumerable();
        }

        public async Task<IEnumerable<Address>> GetByDistrictAsync(string district)
        {
            return await _context.Addresses.AsNoTracking().Where(a => a.District == district).ToListAsync();
        }

        public IEnumerable<Address> GetByNeighbourhood(string neighbourhood)
        {
            return _context.Addresses.AsNoTracking().Where(a => a.Neighbourhood == neighbourhood).AsEnumerable();
        }

        public async Task<IEnumerable<Address>> GetByNeighbourhoodAsync(string neighbourhood)
        {
            return await _context.Addresses.AsNoTracking().Where(a => a.Neighbourhood == neighbourhood).ToListAsync();
        }

        public IEnumerable<Address> GetByStreet(string street)
        {
            return _context.Addresses.AsNoTracking().Where(a => a.Street == street).AsEnumerable();
        }

        public async Task<IEnumerable<Address>> GetByStreetAsync(string street)
        {
            return await _context.Addresses.AsNoTracking().Where(a => a.Street == street).ToListAsync();
        }

        public IEnumerable<Address> GetByUserID(int userID)
        {
            return _context.Addresses.AsNoTracking().Where(a => a.UserID == userID).AsEnumerable();
        }

        public async Task<IEnumerable<Address>> GetByUserIDAsync(int userID)
        {
            return await _context.Addresses.AsNoTracking().Where(a => a.UserID == userID).ToListAsync();
        }
    }
}
