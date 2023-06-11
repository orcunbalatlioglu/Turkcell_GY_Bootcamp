using KidegaClone.DomainService.Repositories;
using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public void Create(CreateNewReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            _reviewRepository.Create(review);
        }

        public int CreateAndReturnId(CreateNewReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            _reviewRepository.Create(review);
            return review.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            await _reviewRepository.CreateAsync(review);
            return review.Id;
        }

        public async Task CreateAsync(CreateNewReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            await _reviewRepository.CreateAsync(review);
        }

        public void Delete(int id)
        {
            _reviewRepository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _reviewRepository.DeleteAsync(id);
        }

        public IEnumerable<DisplayReviewResponse> GetAll()
        {
            var reviews = _reviewRepository.GetAll();
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetAllAsync()
        {
            var reviews = await _reviewRepository.GetAllAsync();
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public IEnumerable<DisplayReviewResponse> GetByBookId(int id)
        {
            var reviews = _reviewRepository.Get(id);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetByBookIdAsync(int id)
        {
            var reviews = await _reviewRepository.GetAsync(id);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public IEnumerable<DisplayReviewResponse> GetByComment(string comment)
        {
            var reviews = _reviewRepository.GetByComment(comment);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetByCommentAsync(string comment)
        {
            var reviews = await _reviewRepository.GetByCommentAsync(comment);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public DisplayReviewResponse GetById(int id)
        {
            var review = _reviewRepository.Get(id);
            var reviewDisplay = _mapper.Map<DisplayReviewResponse>(review);
            return reviewDisplay;
        }

        public async Task<DisplayReviewResponse> GetByIdAsync(int id)
        {
            var review = await _reviewRepository.GetAsync(id);
            var reviewDisplay = _mapper.Map<DisplayReviewResponse>(review);
            return reviewDisplay;
        }

        public IEnumerable<DisplayReviewResponse> GetByRating(decimal rating)
        {
            var reviews = _reviewRepository.GetByRating(rating);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetByRatingAsync(decimal rating)
        {
            var reviews = await _reviewRepository.GetByRatingAsync(rating);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public IEnumerable<DisplayReviewResponse> GetByTitle(string title)
        {
            var reviews = _reviewRepository.GetByTitle(title);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetByTitleAsync(string title)
        {
            var reviews = await _reviewRepository.GetByTitleAsync(title);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public IEnumerable<DisplayReviewResponse> GetByUserId(int userId)
        {
            var reviews = _reviewRepository.GetByUserID(userId);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public async Task<IEnumerable<DisplayReviewResponse>> GetByUserIdAsync(int userId)
        {
            var reviews = await _reviewRepository.GetByUserIDAsync(userId);
            var reviewDisplays = _mapper.Map<IEnumerable<DisplayReviewResponse>>(reviews);
            return reviewDisplays;
        }

        public UpdateReviewRequest GetForUpdate(int id)
        {
            var review = _reviewRepository.Get(id);
            var reviewUpdateRequest = _mapper.Map<UpdateReviewRequest>(review);
            return reviewUpdateRequest;
        }

        public async Task<UpdateReviewRequest> GetForUpdateAsync(int id)
        {
            var review = await _reviewRepository.GetAsync(id);
            var reviewUpdateRequest = _mapper.Map<UpdateReviewRequest>(review);
            return reviewUpdateRequest;
        }

        public bool IsExist(int id)
        {
            return _reviewRepository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _reviewRepository.IsExistsAsync(id);
        }

        public void Update(UpdateReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            _reviewRepository.Update(review);
        }

        public async Task UpdateAsync(UpdateReviewRequest request)
        {
            var review = _mapper.Map<Review>(request);
            await _reviewRepository.UpdateAsync(review);
        }
    }

}
