using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IOrderService : IService<CreateNewOrderRequest, DisplayOrderResponse, UpdateOrderRequest>
    {
        IEnumerable<DisplayOrderResponse> GetByUserId(int userId);
        Task<IEnumerable<DisplayOrderResponse>> GetByUserIdAsync(int userId);
        IEnumerable<DisplayOrderResponse> GetByAddressId(int addressId);
        Task<IEnumerable<DisplayOrderResponse>> GetByAddressIdAsync(int addressId);
        IEnumerable<DisplayOrderResponse> GetByBookId(int bookId);
        Task<IEnumerable<DisplayOrderResponse>> GetByBookIdAsync(int bookId);
        IEnumerable<DisplayOrderResponse> GetSuccesfullOrUnsuccesfullPaid(bool isSuccesfull);
        Task<IEnumerable<DisplayOrderResponse>> GetSuccesfullOrUnsuccesfullPaidAsync(bool isSuccesfull);
    }
}
