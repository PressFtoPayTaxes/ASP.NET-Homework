using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CookieAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using CookieAuthentication.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CookieAuthentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor accessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _logger = logger;
            this.accessor = accessor;
        }

        [Route("Home/Index")]
        public IActionResult Index()
        {
            var userViewModel = new UserViewModel
            {
                Login = accessor.HttpContext.User.Claims.SingleOrDefault(claim => claim.Type == ClaimTypes
                    .UserData).Value,
                FullName = accessor.HttpContext.User.Claims.SingleOrDefault(claim => claim.Type == ClaimTypes
                    .Name).Value,
                Age = int.Parse(accessor.HttpContext.User.Claims.SingleOrDefault(claim => claim.Type == "Age")
                    .Value),
                PhoneNumber = accessor.HttpContext.User.Claims.SingleOrDefault(claim => claim.Type == ClaimTypes
                    .MobilePhone).Value
            };

            return View(userViewModel);
        }

        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/SignOut")]
        public async Task<IActionResult> SignOut()
        {
            await accessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Auth/LogIn");
        }
    }
}
