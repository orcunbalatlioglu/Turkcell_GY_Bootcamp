using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetByUser(User user);
        IEnumerable<Order> GetByUserID(int userID);
        IEnumerable<Order> GetByAddress(Address address);
        IEnumerable<Order> GetByAddressID(int addressID);
        IEnumerable<Order> GetByTotalPrice(int totalPrice);
        IEnumerable<Order> GetBySuccessfullyPaid(bool isSuccessful);
        IEnumerable<Order> GetByBookId(int bookId);
        Task<IEnumerable<Order>> GetByUserAsync(User user);
        Task<IEnumerable<Order>> GetByUserIDAsync(int userID);
        Task<IEnumerable<Order>> GetByAddressAsync(Address address);
        Task<IEnumerable<Order>> GetByAddressIDAsync(int addressID);
        Task<IEnumerable<Order>> GetByTotalPriceAsync(int totalPrice);
        Task<IEnumerable<Order>> GetBySuccessfullyPaidAsync(bool isSuccessful);
        Task<IEnumerable<Order>> GetByBookIdAsync(int bookId);
    }

}
