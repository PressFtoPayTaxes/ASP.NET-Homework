using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieAuthentication.DataAccess;
using CookieAuthentication.Models;
using CookieAuthentication.Services;
using CookieAuthentication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookieAuthentication.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService authService;
        private readonly DataContext context;

        public AuthController(AuthService authService, DataContext context)
        {
            this.authService = authService;
            this.context = context;
        }

        [HttpGet]
        [Route("Auth/LogIn")]
        public IActionResult LogIn()
        {
            return View(new AuthViewModel());
        }

        [HttpGet]
        [Route("Auth/Register")]
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        [Route("Auth/Authenticate")]
        public async Task<IActionResult> Authenticate(AuthViewModel viewModel)
        {
            if(await authService.Authenticate(viewModel.Login, viewModel.Password) == false)
            {
                return Redirect("Unauthorized");
            }

            return Redirect("/Home/Index");
        }

        [HttpPost]
        [Route("Auth/Register")]
        public async Task<IActionResult> Register(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return Redirect("LogIn");
        }

        [Route("Auth/Unauthorized")]
        public IActionResult Unauthorized()
        {
            return View();
        }
    }
}