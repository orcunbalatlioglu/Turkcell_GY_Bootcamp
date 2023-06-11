using KidegaClone.Domain.DTOs.Request;
using KidegaClone.MVC.Models;
using KidegaClone.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KidegaClone.MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {        
        private readonly IUserService _userService;
        private readonly IAddressService _addressService;

        public AdminController(IUserService userService, 
                               IAddressService addressService)
        {
            _userService = userService;
            _addressService = addressService;
        }

        public async Task<IActionResult> ListUsers()
        {
            var allUsers = await _userService.GetAllAsync();
            UserOperationViewModel model = new UserOperationViewModel()
            {
                UserList = allUsers
            };

            return View(model);
        }


        public async Task<IActionResult> AddUser()
        {            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(CreateNewUserRequest createNewUserRequest)
        {
            if(ModelState.IsValid)
            {
                await _userService.CreateAsync(createNewUserRequest);
                return RedirectToAction(nameof(ListUsers));
            }

            return View();
        }


        public async Task<IActionResult> UpdateUser(int userId) 
        {
            var user = await _userService.GetForUpdateAsync(userId);
            if (user != null) {                 
                return View(user);
            }
            return RedirectToAction(nameof(ListUsers));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserRequest request)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.GetForUpdateAsync(request.Id);
                request.Orders = user.Orders;
                request.Reviews = user.Reviews;
                request.Addresses = user.Addresses;
                await _userService.UpdateAsync(request);
                return RedirectToAction(nameof(ListUsers));
            }

            return View();
        }

        public async Task<IActionResult> DeleteUser(int userId)
        {           
            await _userService.DeleteAsync(userId);
            return RedirectToAction(nameof(ListUsers));            
        }


    }
}
