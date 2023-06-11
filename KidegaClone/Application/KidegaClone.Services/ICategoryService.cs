using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface ICategoryService : IService<CreateNewCategoryRequest, DisplayCategoryResponse, UpdateCategoryRequest>
    {
        IEnumerable<DisplayCategoryResponse> GetByBookId(int id);
        Task<IEnumerable<DisplayCategoryResponse>> GetByBookIdAsync(int id);
    }
}
