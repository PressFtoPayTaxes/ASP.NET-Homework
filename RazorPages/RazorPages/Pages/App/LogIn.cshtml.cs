using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.DataAccess;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.Pages.App
{
    public class LogInModel : PageModel
    {
        private readonly AuthService authService;
        private readonly DataContext context;
        [BindProperty]
        public User ExistingUser{ get; set; }

        public LogInModel(AuthService authService, DataContext context)
        {
            this.authService = authService;
            this.context = context;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var token = await authService.Authenticate(ExistingUser.Login, ExistingUser.Password);
            if(token == null)
            {
                return Unauthorized();
            }

            RedirectToPage("Posts");
            return Content(token);
        }
    }
}