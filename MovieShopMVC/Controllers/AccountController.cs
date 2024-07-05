using System;
using System.Security.Claims;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models.RequestModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
	public class AccountController: Controller
	{
        private readonly IAccountService _accountService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IUserService _userService;

        public AccountController(ICurrentUserService currentUserService,
        IUserService userService,
        IAccountService accountService)
		{
            _accountService = accountService;
            _currentUserService = currentUserService;
            _userService = userService;
		}

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequestModel loginRequest, string? returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (!ModelState.IsValid) return View();

            var user = await _accountService.ValidateUser(loginRequest.Email, loginRequest.Password);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }

            var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.Email),
            new(ClaimTypes.GivenName, user.FirstName),
            new(ClaimTypes.Surname, user.LastName),
            new(ClaimTypes.NameIdentifier, user.Id.ToString())
        };

            if (user.Roles != null) claims.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Name)));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

            return LocalRedirect(returnUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel registerModel)
        {
            if (!ModelState.IsValid) return View();
            await _accountService.CreateUser(registerModel);
            return RedirectToAction("Login");
        }
    }
}

