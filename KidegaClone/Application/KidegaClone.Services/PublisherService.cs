using KidegaClone.DomainService.Repositories;
using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

        public void Create(CreateNewPublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            _publisherRepository.Create(publisher);
        }

        public int CreateAndReturnId(CreateNewPublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            _publisherRepository.Create(publisher);
            return publisher.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewPublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            await _publisherRepository.CreateAsync(publisher);
            return publisher.Id;
        }

        public async Task CreateAsync(CreateNewPublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            await _publisherRepository.CreateAsync(publisher);
        }

        public void Delete(int id)
        {
            _publisherRepository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _publisherRepository.DeleteAsync(id);
        }

        public IEnumerable<DisplayPublisherResponse> GetAll()
        {
            var publishers = _publisherRepository.GetAll();
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public async Task<IEnumerable<DisplayPublisherResponse>> GetAllAsync()
        {
            var publishers = await _publisherRepository.GetAllAsync();
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public IEnumerable<DisplayPublisherResponse> GetByBookId(int id)
        {
            var publishers = _publisherRepository.GetByBookId(id);
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public async Task<IEnumerable<DisplayPublisherResponse>> GetByBookIdAsync(int id)
        {
            var publishers = await _publisherRepository.GetByBookIdAsync(id);
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public DisplayPublisherResponse GetById(int id)
        {
            var publisher = _publisherRepository.Get(id);
            var publisherDisplay = _mapper.Map<DisplayPublisherResponse>(publisher);
            return publisherDisplay;
        }

        public async Task<DisplayPublisherResponse> GetByIdAsync(int id)
        {
            var publisher = await _publisherRepository.GetAsync(id);
            var publisherDisplay = _mapper.Map<DisplayPublisherResponse>(publisher);
            return publisherDisplay;
        }

        public IEnumerable<DisplayPublisherResponse> GetByName(string name)
        {
            var publishers = _publisherRepository.GetByName(name);
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public async Task<IEnumerable<DisplayPublisherResponse>> GetByNameAsync(string name)
        {
            var publishers = await _publisherRepository.GetByNameAsync(name);
            var publisherDisplays = _mapper.Map<IEnumerable<DisplayPublisherResponse>>(publishers);
            return publisherDisplays;
        }

        public UpdatePublisherRequest GetForUpdate(int id)
        {
            var publisher = _publisherRepository.Get(id);
            var publisherUpdateRequest = _mapper.Map<UpdatePublisherRequest>(publisher);
            return publisherUpdateRequest;
        }

        public async Task<UpdatePublisherRequest> GetForUpdateAsync(int id)
        {
            var publisher = await _publisherRepository.GetAsync(id);
            var publisherUpdateRequest = _mapper.Map<UpdatePublisherRequest>(publisher);
            return publisherUpdateRequest;
        }

        public bool IsExist(int id)
        {
            return _publisherRepository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _publisherRepository.IsExistsAsync(id);
        }

        public void Update(UpdatePublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            _publisherRepository.Update(publisher);
        }

        public async Task UpdateAsync(UpdatePublisherRequest request)
        {
            var publisher = _mapper.Map<Publisher>(request);
            await _publisherRepository.UpdateAsync(publisher);
        }
    }

}
