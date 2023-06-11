using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IAuthorService : IService<CreateNewAuthorRequest, DisplayAuthorResponse, UpdateAuthorRequest>
    {
        IEnumerable<DisplayAuthorResponse> GetByName(string name);
        Task<IEnumerable<DisplayAuthorResponse>> GetByNameAsync(string name);
        IEnumerable<DisplayAuthorResponse> GetBySurname(string surname);
        Task<IEnumerable<DisplayAuthorResponse>> GetBySurnameAsync(string surname);
    }
}
