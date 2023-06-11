using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Enums;
using KidegaClone.Domain.Entities;


namespace KidegaClone.Services
{
    public interface IUserService : IService<CreateNewUserRequest, DisplayUserResponse, UpdateUserRequest>
    {
        IEnumerable<DisplayUserResponse> GetByName(string name);
        Task<IEnumerable<DisplayUserResponse>> GetByNameAsync(string name);
        IEnumerable<DisplayUserResponse> GetBySurname(string surname);
        Task<IEnumerable<DisplayUserResponse>> GetBySurnameAsync(string surname);
        DisplayUserResponse GetByEmail(string email);
        Task<DisplayUserResponse> GetByEmailAsync(string email);
        IEnumerable<DisplayUserResponse> GetByRole(Role role);
        Task<IEnumerable<DisplayUserResponse>> GetByRoleAsync(Role role);
        IEnumerable<DisplayUserResponse> GetByPhoneNumber(string phoneNo);
        Task<IEnumerable<DisplayUserResponse>> GetByPhoneNumberAsync(string phoneNo);
        User? Validate(string email, string password);
        Task<User?> ValidateAsync(string email, string password);
    }
}
