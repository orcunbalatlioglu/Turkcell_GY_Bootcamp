using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetByName(string name);
        IEnumerable<Book> GetByCategory(Category category);
        IEnumerable<Book> GetByCategoryID(int categoryId);
        IEnumerable<Book> GetByAuthor(Author author);
        IEnumerable<Book> GetByAuthorID(int id);
        IEnumerable<Book> GetByPublisher(Publisher publisher);
        IEnumerable<Book> GetByPublisherID(int id);
        IEnumerable<Book> GetByPublishDate(DateTime date);
        IEnumerable<Book> GetByRating(decimal rating);
        IEnumerable<Book> GetByCover(bool isHard);
        IEnumerable<Book> GetByBarcode(long barcode);
        Task<IEnumerable<Book>> GetByNameAsync(string name);
        Task<IEnumerable<Book>> GetByCategoryAsync(Category category);
        Task<IEnumerable<Book>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Book>> GetByAuthorAsync(Author author);
        Task<IEnumerable<Book>> GetByAuthorIDAsync(int id);
        Task<IEnumerable<Book>> GetByPublisherAsync(Publisher publisher);
        Task<IEnumerable<Book>> GetByPublisherIDAsync(int id);
        Task<IEnumerable<Book>> GetByPublishDateAsync(DateTime date);
        Task<IEnumerable<Book>> GetByRatingAsync(decimal rating);
        Task<IEnumerable<Book>> GetByCoverAsync(bool isHard);
        Task<IEnumerable<Book>> GetByBarcodeAsync(long barcode);
    }

}
