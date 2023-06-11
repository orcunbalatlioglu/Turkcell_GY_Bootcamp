using AutoMapper;
using KidegaClone.DomainService.Repositories;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(CreateNewAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);            
            _repository.Create(author);
        }

        public int CreateAndReturnId(CreateNewAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            _repository.Create(author);
            return author.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            await _repository.CreateAsync(author);
            return author.Id;
        }

        public async Task CreateAsync(CreateNewAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            await _repository.CreateAsync(author);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public IEnumerable<DisplayAuthorResponse> GetAll()
        {
            var authors = _repository.GetAll();
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public async Task<IEnumerable<DisplayAuthorResponse>> GetAllAsync()
        {
            var authors = await _repository.GetAllAsync();
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public DisplayAuthorResponse GetById(int id)
        {
            var author = _repository.Get(id);
            var authorDisplay = _mapper.Map<DisplayAuthorResponse>(author);
            return authorDisplay;
        }

        public async Task<DisplayAuthorResponse> GetByIdAsync(int id)
        {
            var author = await _repository.GetAsync(id);
            var authorDisplay = _mapper.Map<DisplayAuthorResponse>(author);
            return authorDisplay;
        }

        public IEnumerable<DisplayAuthorResponse> GetByName(string name)
        {
            var authors = _repository.GetByName(name);
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public async Task<IEnumerable<DisplayAuthorResponse>> GetByNameAsync(string name)
        {
            var authors = await _repository.GetByNameAsync(name);
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public IEnumerable<DisplayAuthorResponse> GetBySurname(string surname)
        {
            var authors = _repository.GetBySurname(surname);
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public async Task<IEnumerable<DisplayAuthorResponse>> GetBySurnameAsync(string surname)
        {
            var authors = await _repository.GetBySurnameAsync(surname);
            var authorsDisplay = _mapper.Map<IEnumerable<DisplayAuthorResponse>>(authors);
            return authorsDisplay;
        }

        public UpdateAuthorRequest GetForUpdate(int id)
        {
            var author = _repository.Get(id);
            var authorDisplay = _mapper.Map<UpdateAuthorRequest>(author);
            return authorDisplay;
        }

        public async Task<UpdateAuthorRequest> GetForUpdateAsync(int id)
        {
            var author = await _repository.GetAsync(id);
            var authorDisplay = _mapper.Map<UpdateAuthorRequest>(author);
            return authorDisplay;
        }

        public bool IsExist(int id)
        {            
            return _repository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _repository.IsExistsAsync(id);
        }

        public void Update(UpdateAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            _repository.Update(author);
        }

        public async Task UpdateAsync(UpdateAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            await _repository.UpdateAsync(author);
        }
    }
}
