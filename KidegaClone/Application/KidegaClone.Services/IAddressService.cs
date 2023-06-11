using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IAddressService : IService<CreateNewAddressRequest, DisplayAddressResponse, UpdateAddressRequest>
    {
        IEnumerable<DisplayAddressResponse> GetByCity(string city);
        Task<IEnumerable<DisplayAddressResponse>> GetByCityAsync(string city);
        IEnumerable<DisplayAddressResponse> GetByDistrict(string district);
        Task<IEnumerable<DisplayAddressResponse>> GetByDistrictAsync(string district);
        IEnumerable<DisplayAddressResponse> GetByNeighbourhood(string neighbourhood);
        Task<IEnumerable<DisplayAddressResponse>> GetByNeighbourhoodAsync(string neighbourhood);
        IEnumerable<DisplayAddressResponse> GetByStreet(string street);
        Task<IEnumerable<DisplayAddressResponse>> GetByStreetAsync(string street);
        IEnumerable<DisplayAddressResponse> GetByUserId(int userId);
        Task<IEnumerable<DisplayAddressResponse>> GetByUserIdAsync(int userId);
    }
}
