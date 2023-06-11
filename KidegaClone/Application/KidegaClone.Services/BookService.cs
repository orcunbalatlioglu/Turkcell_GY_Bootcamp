using KidegaClone.DomainService.Repositories;
using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(CreateNewBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            _repository.Create(book);
        }

        public int CreateAndReturnId(CreateNewBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            _repository.Create(book);
            return book.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            await _repository.CreateAsync(book);
            return book.Id;
        }

        public async Task CreateAsync(CreateNewBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            await _repository.CreateAsync(book);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public IEnumerable<DisplayBookResponse> GetAll()
        {
            var books = _repository.GetAll();
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetAllAsync()
        {
            var books = await _repository.GetAllAsync();
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetByAuthorId(int id)
        {
            var books = _repository.GetByAuthorID(id);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetByAuthorIdAsync(int id)
        {
            var books = await _repository.GetByAuthorIDAsync(id);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetByBarcode(long barcode)
        {
            var books = _repository.GetByBarcode(barcode);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetByBarcodeAsync(long barcode)
        {
            var books = await _repository.GetByBarcodeAsync(barcode);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetByCategoryId(int categoryId)
        {
            var books = _repository.GetByCategoryID(categoryId);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetByCategoryIdAsync(int categoryId)
        {
            var books = await _repository.GetByCategoryIdAsync(categoryId);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public DisplayBookResponse GetById(int id)
        {
            var book = _repository.Get(id);
            var bookDisplay = _mapper.Map<DisplayBookResponse>(book);
            return bookDisplay;
        }

        public async Task<DisplayBookResponse> GetByIdAsync(int id)
        {
            var book = await _repository.GetAsync(id);
            var bookDisplay = _mapper.Map<DisplayBookResponse>(book);
            return bookDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetByName(string name)
        {
            var books = _repository.GetByName(name);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetByNameAsync(string name)
        {
            var books = await _repository.GetByNameAsync(name);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetByPublisherId(int id)
        {
            var books = _repository.GetByPublisherID(id);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetByPublisherIdAsync(int id)
        {
            var books = await _repository.GetByPublisherIDAsync(id);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public UpdateBookRequest GetForUpdate(int id)
        {
            var book = _repository.Get(id);
            var bookDisplay = _mapper.Map<UpdateBookRequest>(book);
            return bookDisplay;
        }

        public async Task<UpdateBookRequest> GetForUpdateAsync(int id)
        {
            var book = await _repository.GetAsync(id);
            var bookDisplay = _mapper.Map<UpdateBookRequest>(book);
            return bookDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetHardOrSoftCoverBooks(bool isHard)
        {
            var books = _repository.GetByCover(isHard);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetHardOrSoftCoverBooksAsync(bool isHard)
        {
            var books = await _repository.GetByCoverAsync(isHard);
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(books);
            return booksDisplay;
        }

        public IEnumerable<DisplayBookResponse> GetTopRatedBooks(int limit)
        {
            var sortedBooks = _repository.GetAll()
                                         .OrderByDescending(b=> b.Rating)
                                         .Take(limit);
            
            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(sortedBooks);
            return booksDisplay;
        }

        public async Task<IEnumerable<DisplayBookResponse>> GetTopRatedBooksAsync(int limit)
        {
            var books = await _repository.GetAllAsync();
            var sortedBooks = books.OrderByDescending(b => b.Rating)
                                   .Take(limit);

            var booksDisplay = _mapper.Map<IEnumerable<DisplayBookResponse>>(sortedBooks);
            return booksDisplay;
        }

        public bool IsExist(int id)
        {
            return _repository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _repository.IsExistsAsync(id);
        }

        public void Update(UpdateBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            _repository.Update(book);
        }

        public async Task UpdateAsync(UpdateBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            await _repository.UpdateAsync(book);
        }
    }

}
