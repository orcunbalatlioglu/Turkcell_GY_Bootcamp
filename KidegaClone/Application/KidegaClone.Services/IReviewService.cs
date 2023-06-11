using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.Services
{
    public interface IReviewService : IService<CreateNewReviewRequest, DisplayReviewResponse, UpdateReviewRequest>
    {
        IEnumerable<DisplayReviewResponse> GetByUserId(int userId);
        Task<IEnumerable<DisplayReviewResponse>> GetByUserIdAsync(int userId);
        IEnumerable<DisplayReviewResponse> GetByBookId(int id);
        Task<IEnumerable<DisplayReviewResponse>> GetByBookIdAsync(int id);
        IEnumerable<DisplayReviewResponse> GetByTitle(string title);
        Task<IEnumerable<DisplayReviewResponse>> GetByTitleAsync(string title);
        IEnumerable<DisplayReviewResponse> GetByComment(string comment);
        Task<IEnumerable<DisplayReviewResponse>> GetByCommentAsync(string comment);
        IEnumerable<DisplayReviewResponse> GetByRating(decimal rating);
        Task<IEnumerable<DisplayReviewResponse>> GetByRatingAsync(decimal rating);
    }
}
