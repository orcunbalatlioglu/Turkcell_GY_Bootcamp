using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.MVC.Extensions;
using KidegaClone.MVC.Models;
using KidegaClone.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaClone.MVC.Controllers
{
    public class ShopController : Controller
    {

        private readonly IBookService _bookService;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public ShopController(IBookService bookService,
                              IOrderService orderService,
                              IUserService userService) 
        { 
            _bookService = bookService;
            _orderService = orderService;
            _userService = userService;
        }

        public async Task<IActionResult> Cart(int userId)
        {
            var cartContent = getCartContentFromSession();
            CartViewModel cartViewModel = new CartViewModel()
            {
                Cart = cartContent,
                Address = 
            }
            return View(cartContent);
        }

        public async Task<IActionResult> AddToCart(int bookId)
        {
            DisplayBookResponse selectedBook = await _bookService.GetByIdAsync(bookId);
            var cartItem = new CartItem { Book = selectedBook, Quantity = 1 };

            CartContent cartContent = getCartContentFromSession();
            cartContent.AddNewCourse(cartItem);
            saveToSession(cartContent);

            return RedirectToAction("BookDetail", "Home", new { bookId = selectedBook.Id });
        }

        public async Task<IActionResult> GiveOrder(int addressId, int userId)
        {           
            var user = await _userService.GetByIdAsync(userId);            
            if(user != null) 
            { 
                var cartContent = getCartContentFromSession();
                CreateNewOrderRequest orderRequest = new CreateNewOrderRequest()
                {
                    UserID = user.Id,
                    AddressID = addressId
                };
                await _orderService.CreateAsync(orderRequest);

                return RedirectToAction("Cart", "Shop");
            }
            return RedirectToAction("Index", "Home");
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
