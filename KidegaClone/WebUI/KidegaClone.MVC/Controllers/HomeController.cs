using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using KidegaClone.MVC.Models;
using KidegaClone.Services;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.MVC.Cache;

namespace KidegaClone.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IPublisherService _publisherService;
        private readonly ICategoryService _categoryService;
        private readonly IMemoryCache _memoryCache;

        public HomeController(ILogger<HomeController> logger, 
                              IBookService bookService,
                              IAuthorService authorService,
                              IPublisherService publisherService,
                              ICategoryService categoryService,
                              IMemoryCache memoryCache)
        {
            _logger = logger;
            _bookService = bookService;            
            _authorService = authorService;
            _publisherService = publisherService;
            _categoryService = categoryService;
            _memoryCache = memoryCache;
        }

        public async Task<IActionResult> Index(int pageNo = 1, int? id = null)
        {
            IEnumerable<DisplayBookResponse> books = await getBooksMemCacheOrDb(id);
            
            var bookPerPage = 6;
            var bookCount = books.Count();
            var totalPage = Math.Ceiling((decimal)bookCount / bookPerPage);

            var pagingInfo = new PaginationInfo
            {
                CurrentPage = pageNo,
                ItemsPerPage = bookPerPage,
                TotalItems = bookCount
            };

            var paginatedBooks = books.Skip((pageNo - 1) * bookPerPage)
                                      .Take(bookPerPage)
                                      .ToList();

            ICollection<BookComponentInfo> bookComponentInfos = new List<BookComponentInfo>();
            foreach (var item in paginatedBooks)
            {
                var publisher = _publisherService.GetById(item.PublisherID);
                var author = _authorService.GetById(item.AuthorID);
                var component = new BookComponentInfo()
                {
                    Id  = item.Id,
                    Name = item.Name,
                    Picture = item.Picture,
                    PublisherName = publisher.Name,
                    AuthorName = author.Name + " " +author.Surname,
                    Price = item.Price,
                    Rating = item.Rating
                };
                bookComponentInfos.Add(component);                              
            }

            var model = new BookSearchViewModel()
            {
                Categories = _categoryService.GetAll(),
                Books = bookComponentInfos,
                PaginationInfo = pagingInfo
            };

            return View(model);
        }

        public async Task<IActionResult> BookDetail(int bookId)
        {
            var bookResponse = await _bookService.GetByIdAsync(bookId);
            var authorResponse = await _authorService.GetByIdAsync(bookResponse.AuthorID);
            BookDetailViewModel model = new BookDetailViewModel() { Book = bookResponse, Author = authorResponse };

            return View(model);
        }

        public async Task<IActionResult> AuthorDetail(int authorId)
        {
            var authorResponse = await _authorService.GetByIdAsync(authorId);
            var authorBooks = await _bookService.GetByAuthorIdAsync(authorId);
            List<BookComponentInfo> bookComponentInfos = new List<BookComponentInfo>();
            foreach (var bookInfo in authorBooks) 
            {
                BookComponentInfo bookComponentInfo = new BookComponentInfo()
                {
                    Id = bookInfo.Id,
                    Name = bookInfo.Name,
                    Picture = bookInfo.Picture,
                    PublisherName = bookInfo.Name,
                    AuthorName = authorResponse.Name + " " + authorResponse.Surname,
                    Price = bookInfo.Price,
                    Rating = bookInfo.Rating
                };
                bookComponentInfos.Add(bookComponentInfo);                                
            }
            AuthorDetailViewModel model = new AuthorDetailViewModel() { Author = authorResponse, BooksOfAuthor = bookComponentInfos };

            return View(model);
        }

        private async Task<IEnumerable<DisplayBookResponse>> getBooksMemCacheOrDb(int? id)
        {
            if (id == null)
            {
                if (!_memoryCache.TryGetValue("topRatedBooks", out CacheData cacheDataInfo))
                {
                    var options = new MemoryCacheEntryOptions()
                                      .SetSlidingExpiration(TimeSpan.FromMinutes(1))
                                      .SetPriority(CacheItemPriority.Normal);
                    IEnumerable<DisplayBookResponse> books;

                    books = await _bookService.GetTopRatedBooksAsync(10);
                    cacheDataInfo = new CacheData
                    {
                        CacheTime = DateTime.Now,
                        Books = books
                    };
                    _memoryCache.Set("topRatedBooks", cacheDataInfo, options);
                }
                return cacheDataInfo.Books;
            } 
            
            else
            {                
                if (!_memoryCache.TryGetValue("booksByCategories"+id.ToString(), out CacheData cacheDataInfo))
                {
                    var options = new MemoryCacheEntryOptions()
                                      .SetSlidingExpiration(TimeSpan.FromMinutes(1))
                                      .SetPriority(CacheItemPriority.Normal);
                    IEnumerable<DisplayBookResponse> books;

                    books = await _bookService.GetByCategoryIdAsync((int)id);
                    cacheDataInfo = new CacheData
                    {
                        CacheTime = DateTime.Now,
                        Books = books
                    };
                    _memoryCache.Set("topRatedBooks", cacheDataInfo, options);
                }
                return cacheDataInfo.Books;
            }

        }

    }
}