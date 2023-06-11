using KidegaClone.Domain.Entities;

namespace KidegaClone.DomainService.Repositories
{
    public interface IReviewRepository : IRepository<Review>
    {
        IEnumerable<Review> GetByUser(User user);
        IEnumerable<Review> GetByUserID(int userID);
        IEnumerable<Review> GetByBook(Book book);
        IEnumerable<Review> GetByBookID(int bookID);
        IEnumerable<Review> GetByComment(string comment);
        IEnumerable<Review> GetByRating(decimal rating);
        IEnumerable<Review> GetByTitle(string title);
        Task<IEnumerable<Review>> GetByUserAsync(User user);
        Task<IEnumerable<Review>> GetByUserIDAsync(int userID);
        Task<IEnumerable<Review>> GetByBookAsync(Book book);
        Task<IEnumerable<Review>> GetByBookIDAsync(int bookID);
        Task<IEnumerable<Review>> GetByCommentAsync(string comment);
        Task<IEnumerable<Review>> GetByRatingAsync(decimal rating);        
        Task<IEnumerable<Review>> GetByTitleAsync(string title);
    }

}
