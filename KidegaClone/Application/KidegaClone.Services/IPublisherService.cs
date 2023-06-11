using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IPublisherService : IService<CreateNewPublisherRequest, DisplayPublisherResponse, UpdatePublisherRequest>
    {
        IEnumerable<DisplayPublisherResponse> GetByName(string name);
        Task<IEnumerable<DisplayPublisherResponse>> GetByNameAsync(string name);
        IEnumerable<DisplayPublisherResponse> GetByBookId(int id);
        Task<IEnumerable<DisplayPublisherResponse>> GetByBookIdAsync(int id);
    }
}
