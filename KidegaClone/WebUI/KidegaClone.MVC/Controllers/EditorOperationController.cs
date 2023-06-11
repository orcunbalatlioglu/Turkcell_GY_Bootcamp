using KidegaClone.MVC.Models;
using KidegaClone.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KidegaClone.MVC.Controllers
{
    [Authorize(Roles ="Editor,Admin")]
    public class EditorOperationController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public EditorOperationController(IAddressService addressService,
                                         IOrderService orderService,
                                         IUserService userService) 
        { 
            _addressService = addressService;
            _userService = userService;
            _orderService = orderService;        
        }

        public async Task<IActionResult> Orders()
        {
            List<OrderListItem> orderListItems = new List<OrderListItem>();
            var orderList = await _orderService.GetAllAsync();

            foreach (var order in orderList)
            {
                var orderAddress = await _addressService.GetByIdAsync(order.AddressID);
                OrderListItem item = new OrderListItem()
                {
                    OrderResponse = order,
                    AddressResponse = orderAddress
                };
                orderListItems.Add(item);
            }
            
            return View(orderListItems);
        }

    }
}
