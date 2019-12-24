using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCoreVsMvcFrameworkComparison2.DataAccess;
using AspNetMvcCoreVsMvcFrameworkComparison2.Models;
using AspNetMvcCoreVsMvcFrameworkComparison2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly AuthService authService;
        private readonly DataContext context;

        public AdminController(AuthService authService, DataContext context)
        {
            this.authService = authService;
            this.context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(new Admin());
        }

        public async Task<IActionResult> Edit()
        {
            var portfolio = (await context.Portfolios.ToListAsync())[0];

            return View(portfolio);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate(Admin admin)
        {
            var isAuthenticated = await authService.Authenticate(admin.Login, admin.Password);

            if (isAuthenticated)
                return Redirect("Edit");
            else
                return Unauthorized();
        }

    }
}