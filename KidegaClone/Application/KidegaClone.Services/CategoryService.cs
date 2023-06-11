using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;
using KidegaClone.DomainService.Repositories;

namespace KidegaClone.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public void Create(CreateNewCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _categoryRepository.Create(category);
        }

        public int CreateAndReturnId(CreateNewCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _categoryRepository.Create(category);
            return category.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            await _categoryRepository.CreateAsync(category);
            return category.Id;
        }

        public async Task CreateAsync(CreateNewCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            await _categoryRepository.CreateAsync(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public IEnumerable<DisplayCategoryResponse> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            var categoriesDisplay = _mapper.Map<IEnumerable<DisplayCategoryResponse>>(categories);
            return categoriesDisplay;
        }

        public async Task<IEnumerable<DisplayCategoryResponse>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            var categoriesDisplay = _mapper.Map<IEnumerable<DisplayCategoryResponse>>(categories);
            return categoriesDisplay;
        }

        public IEnumerable<DisplayCategoryResponse> GetByBookId(int id)
        {
            var categories = _categoryRepository.Get(id);
            var categoriesDisplay = _mapper.Map<IEnumerable<DisplayCategoryResponse>>(categories);
            return categoriesDisplay;
        }

        public async Task<IEnumerable<DisplayCategoryResponse>> GetByBookIdAsync(int id)
        {
            var categories = await _categoryRepository.GetAsync(id);
            var categoriesDisplay = _mapper.Map<IEnumerable<DisplayCategoryResponse>>(categories);
            return categoriesDisplay;
        }

        public DisplayCategoryResponse GetById(int id)
        {
            var category = _categoryRepository.Get(id);
            var categoryDisplay = _mapper.Map<DisplayCategoryResponse>(category);
            return categoryDisplay;
        }

        public async Task<DisplayCategoryResponse> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetAsync(id);
            var categoryDisplay = _mapper.Map<DisplayCategoryResponse>(category);
            return categoryDisplay;
        }

        public UpdateCategoryRequest GetForUpdate(int id)
        {
            var category = _categoryRepository.Get(id);
            var categoryDisplay = _mapper.Map<UpdateCategoryRequest>(category);
            return categoryDisplay;
        }

        public async Task<UpdateCategoryRequest> GetForUpdateAsync(int id)
        {
            var category = await _categoryRepository.GetAsync(id);
            var categoryDisplay = _mapper.Map<UpdateCategoryRequest>(category);
            return categoryDisplay;
        }

        public bool IsExist(int id)
        {
            return _categoryRepository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _categoryRepository.IsExistsAsync(id);
        }

        public void Update(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _categoryRepository.Update(category);
        }

        public async Task UpdateAsync(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            await _categoryRepository.UpdateAsync(category);
        }
    }

}
