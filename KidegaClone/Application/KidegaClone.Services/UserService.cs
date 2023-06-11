using KidegaClone.DomainService.Repositories;
using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;

namespace KidegaClone.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Create(CreateNewUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _userRepository.Create(user);
        }

        public int CreateAndReturnId(CreateNewUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _userRepository.Create(user);
            return user.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.CreateAsync(user);
            return user.Id;
        }

        public async Task CreateAsync(CreateNewUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.CreateAsync(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public IEnumerable<DisplayUserResponse> GetAll()
        {
            var users = _userRepository.GetAll();
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public async Task<IEnumerable<DisplayUserResponse>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public DisplayUserResponse GetByEmail(string email)
        {
            var users = _userRepository.GetByEmail(email);
            var userDisplays = _mapper.Map<DisplayUserResponse>(users);
            return userDisplays;
        }

        public async Task<DisplayUserResponse> GetByEmailAsync(string email)
        {
            var users = await _userRepository.GetByEmailAsync(email);
            var userDisplays = _mapper.Map<DisplayUserResponse>(users);
            return userDisplays;
        }

        public DisplayUserResponse GetById(int id)
        {
            var user = _userRepository.Get(id);
            var userDisplay = _mapper.Map<DisplayUserResponse>(user);
            return userDisplay;
        }

        public async Task<DisplayUserResponse> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetAsync(id);
            var userDisplay = _mapper.Map<DisplayUserResponse>(user);
            return userDisplay;
        }

        public IEnumerable<DisplayUserResponse> GetByName(string name)
        {
            var users = _userRepository.GetByName(name);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public async Task<IEnumerable<DisplayUserResponse>> GetByNameAsync(string name)
        {
            var users = await _userRepository.GetByNameAsync(name);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public IEnumerable<DisplayUserResponse> GetByPhoneNumber(string phoneNo)
        {
            var users = _userRepository.GetByPhoneNumber(phoneNo);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public async Task<IEnumerable<DisplayUserResponse>> GetByPhoneNumberAsync(string phoneNo)
        {
            var users = await _userRepository.GetByPhoneNumberAsync(phoneNo);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public IEnumerable<DisplayUserResponse> GetByRole(Role role)
        {
            var users = _userRepository.GetByRole(role);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public async Task<IEnumerable<DisplayUserResponse>> GetByRoleAsync(Role role)
        {
            var users = await _userRepository.GetByRoleAsync(role);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public IEnumerable<DisplayUserResponse> GetBySurname(string surname)
        {
            var users = _userRepository.GetBySurname(surname);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public async Task<IEnumerable<DisplayUserResponse>> GetBySurnameAsync(string surname)
        {
            var users = await _userRepository.GetBySurnameAsync(surname);
            var userDisplays = _mapper.Map<IEnumerable<DisplayUserResponse>>(users);
            return userDisplays;
        }

        public UpdateUserRequest GetForUpdate(int id)
        {
            var user = _userRepository.Get(id);
            var userUpdateRequest = _mapper.Map<UpdateUserRequest>(user);
            return userUpdateRequest;
        }

        public async Task<UpdateUserRequest> GetForUpdateAsync(int id)
        {
            var user = await _userRepository.GetAsync(id);
            var userUpdateRequest = _mapper.Map<UpdateUserRequest>(user);
            return userUpdateRequest;
        }

        public bool IsExist(int id)
        {
            return _userRepository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _userRepository.IsExistsAsync(id);
        }

        public void Update(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _userRepository.Update(user);
        }

        public async Task UpdateAsync(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.UpdateAsync(user);
        }

        public User? Validate(string email, string password)
        {
            return _userRepository.GetAll().SingleOrDefault(u => u.Email == email && u.Password == password);
        }

        public async Task<User?> ValidateAsync(string email, string password)
        {
            var users = await _userRepository.GetAllAsync();
            return users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
