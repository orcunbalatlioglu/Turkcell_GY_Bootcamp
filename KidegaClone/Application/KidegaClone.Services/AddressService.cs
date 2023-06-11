using AutoMapper;
using KidegaClone.DomainService.Repositories;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(CreateNewAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            _repository.Create(address);
        }

        public int CreateAndReturnId(CreateNewAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            _repository.Create(address);
            return address.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            await _repository.CreateAsync(address);
            return address.Id;
        }

        public async Task CreateAsync(CreateNewAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            await _repository.CreateAsync(address);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public IEnumerable<DisplayAddressResponse> GetAll()
        {
            var addresses = _repository.GetAll();
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetAllAsync()
        {
            var addresses = await _repository.GetAllAsync();
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public IEnumerable<DisplayAddressResponse> GetByCity(string city)
        {
            var addresses = _repository.GetByCity(city);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetByCityAsync(string city)
        {
            var addresses = await _repository.GetByCityAsync(city);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public IEnumerable<DisplayAddressResponse> GetByDistrict(string district)
        {
            var addresses = _repository.GetByDistrict(district);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetByDistrictAsync(string district)
        {
            var addresses = await _repository.GetByDistrictAsync(district);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public DisplayAddressResponse GetById(int id)
        {
            var address = _repository.Get(id);
            var addressDisplay = _mapper.Map<DisplayAddressResponse>(address);
            return addressDisplay;
        }

        public async Task<DisplayAddressResponse> GetByIdAsync(int id)
        {
            var address = await _repository.GetAsync(id);
            var addressDisplay = _mapper.Map<DisplayAddressResponse>(address);
            return addressDisplay;
        }

        public IEnumerable<DisplayAddressResponse> GetByNeighbourhood(string neighbourhood)
        {
            var addresses = _repository.GetByNeighbourhood(neighbourhood);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetByNeighbourhoodAsync(string neighbourhood)
        {
            var addresses = await _repository.GetByNeighbourhoodAsync(neighbourhood);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public IEnumerable<DisplayAddressResponse> GetByStreet(string street)
        {
            var addresses = _repository.GetByStreet(street);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetByStreetAsync(string street)
        {
            var addresses = await _repository.GetByStreetAsync(street);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public IEnumerable<DisplayAddressResponse> GetByUserId(int userId)
        {
            var addresses = _repository.Get(userId);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public async Task<IEnumerable<DisplayAddressResponse>> GetByUserIdAsync(int userId)
        {
            var addresses = await _repository.GetAsync(userId);
            var addressesDisplay = _mapper.Map<IEnumerable<DisplayAddressResponse>>(addresses);
            return addressesDisplay;
        }

        public UpdateAddressRequest GetForUpdate(int id)
        {
            var address = _repository.Get(id);
            var addressDisplay = _mapper.Map<UpdateAddressRequest>(address);
            return addressDisplay;
        }

        public async Task<UpdateAddressRequest> GetForUpdateAsync(int id)
        {
            var address = await _repository.GetAsync(id);
            var addressDisplay = _mapper.Map<UpdateAddressRequest>(address);
            return addressDisplay;
        }

        public bool IsExist(int id)
        {
            return _repository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _repository.IsExistsAsync(id);
        }

        public void Update(UpdateAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            _repository.Update(address);
        }

        public async Task UpdateAsync(UpdateAddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            await _repository.UpdateAsync(address);
        }
    }

}
