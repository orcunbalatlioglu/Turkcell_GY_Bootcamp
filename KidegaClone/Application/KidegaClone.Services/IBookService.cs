using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IBookService : IService<CreateNewBookRequest, DisplayBookResponse, UpdateBookRequest>
    {
        IEnumerable<DisplayBookResponse> GetByCategoryId(int categoryId);
        Task<IEnumerable<DisplayBookResponse>> GetByCategoryIdAsync(int categoryId);
        IEnumerable<DisplayBookResponse> GetByName(string name);
        Task<IEnumerable<DisplayBookResponse>> GetByNameAsync(string name);
        IEnumerable<DisplayBookResponse> GetByAuthorId(int id);
        Task<IEnumerable<DisplayBookResponse>> GetByAuthorIdAsync(int id);
        IEnumerable<DisplayBookResponse> GetByPublisherId(int id);
        Task<IEnumerable<DisplayBookResponse>> GetByPublisherIdAsync(int id);
        IEnumerable<DisplayBookResponse> GetTopRatedBooks(int limit);
        Task<IEnumerable<DisplayBookResponse>> GetTopRatedBooksAsync(int limit);
        IEnumerable<DisplayBookResponse> GetHardOrSoftCoverBooks(bool isHard);
        Task<IEnumerable<DisplayBookResponse>> GetHardOrSoftCoverBooksAsync(bool isHard);
        IEnumerable<DisplayBookResponse> GetByBarcode(long barcode);
        Task<IEnumerable<DisplayBookResponse>> GetByBarcodeAsync(long barcode);
    }
}
