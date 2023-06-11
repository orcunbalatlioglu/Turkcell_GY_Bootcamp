using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetByUserID(int userID);
        Task<IEnumerable<Address>> GetByUserIDAsync(int userID);
        IEnumerable<Address> GetByCity(string city);
        Task<IEnumerable<Address>> GetByCityAsync(string city);
        IEnumerable<Address> GetByDistrict(string district);
        Task<IEnumerable<Address>> GetByDistrictAsync(string district);
        IEnumerable<Address> GetByNeighbourhood(string neighbourhood);
        Task<IEnumerable<Address>> GetByNeighbourhoodAsync(string neighbourhood);
        IEnumerable<Address> GetByStreet(string street);
        Task<IEnumerable<Address>> GetByStreetAsync(string street);
    }
}
