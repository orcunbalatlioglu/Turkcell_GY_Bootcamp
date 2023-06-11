using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;
using KidegaClone.MVC.Extensions;
using KidegaClone.MVC.Models;
using KidegaClone.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KidegaClone.MVC.Controllers
{
    [Authorize(Roles = "Client")]
    public class ShopController : Controller
    {

        private readonly IBookService _bookService;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IAddressService _addressService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public ShopController(IBookService bookService,
                              IOrderService orderService,
                              IUserService userService,
                              IAddressService addressService,
                              IHttpContextAccessor httpContextAccessor,
                              IMapper mapper) 
        { 
            _bookService = bookService;
            _orderService = orderService;
            _userService = userService;
            _addressService = addressService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<IActionResult> Cart()
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cartContent = getCartContentFromSession();
            decimal totalCartPrice = 0;
            foreach (var item in cartContent.Content)
            {
                totalCartPrice += (item.Book.Price) * item.Quantity;
            }
            CartViewModel cartViewModel = new CartViewModel()
            {
                Cart = cartContent,
                CartUser = await _userService.GetByIdAsync(Convert.ToInt32(userId)),
                Address = await _addressService.GetByUserIdAsync(Convert.ToInt32(userId)),
                TotalCartPrice = totalCartPrice
            };
            return View(cartViewModel);
        }

        public async Task<IActionResult> AddToCart(int bookId)
        {
            DisplayBookResponse selectedBook = await _bookService.GetByIdAsync(bookId);
            var cartItem = new CartItem { Book = selectedBook, Quantity = 1 };

            CartContent cartContent = getCartContentFromSession();
            cartContent.AddNewBook(cartItem);
            saveToSession(cartContent);

            return RedirectToAction("BookDetail", "Home", new { bookId = selectedBook.Id });
        }

        public async Task<IActionResult> GiveOrder(int selectComponentAddressValue, int userId, int totalPrice)
        {           
            var user = await _userService.GetByIdAsync(userId);
            var addressesOfUser = await _addressService.GetByUserIdAsync(userId);
            int selectedUserAddress = 0;

            var addressCount = 0;
            foreach (var address in addressesOfUser)
            {
                if (addressCount == selectComponentAddressValue)
                {
                    selectedUserAddress = address.Id;
                    break;
                }
                addressCount++;
            }

            if (user != null && selectedUserAddress != 0) 
            { 
                var cartContent = getCartContentFromSession();
                var orderDisplayBooks = cartContent.GetAllBooks();
                List<BookOrder> booksInOrder = new List<BookOrder>();

                foreach (var orderBook in orderDisplayBooks)
                {
                    BookOrder bookOrder = new BookOrder { BookID = orderBook.Id }; 
                    booksInOrder.Add(bookOrder);
                }

                CreateNewOrderRequest orderRequest = new CreateNewOrderRequest()
                {
                    UserID = user.Id,
                    Books = booksInOrder,
                    AddressID = selectedUserAddress,
                    TotalPrice = cartContent.TotalBookPrice()
                };
                await _orderService.CreateAsync(orderRequest);
                cartContent.ClearAll();
                saveToSession(cartContent);
                return RedirectToAction("Cart", "Shop");
            }

            return RedirectToAction("Cart", "Shop");
        }


        private CartContent getCartContentFromSession()
        {
            return HttpContext.Session.GetJson<CartContent>("Cart") ?? new CartContent();
        }

        private void saveToSession(CartContent courseCollection)
        {

            HttpContext.Session.SetJson("Cart", courseCollection);

        }
    }
}
