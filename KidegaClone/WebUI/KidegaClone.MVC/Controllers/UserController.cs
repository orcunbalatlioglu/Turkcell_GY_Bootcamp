using Microsoft.AspNetCore.Mvc;
using KidegaClone.MVC.Models;
using KidegaClone.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace KidegaClone.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login(string? routedPage)
        {
            ViewBag.ReturnUrl = routedPage;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin, string? routedPage)
        {
            if(ModelState.IsValid)
            {
                var user = await _userService.ValidateAsync(userLogin.Email, userLogin.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    if (!string.IsNullOrEmpty(routedPage) && Url.IsLocalUrl(routedPage))
                    {
                        return Redirect(routedPage);
                    }
                    return Redirect("/");

                }
                ModelState.AddModelError("login", "Kullanıcı adı ya da şifre yanlış!");


            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

    }
}
