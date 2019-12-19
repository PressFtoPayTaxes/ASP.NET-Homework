using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.DataAccess;
using RazorPages.Models;

namespace RazorPages.Pages.App
{
    public class RegisterModel : PageModel
    {
        public RegisterModel(DataContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public User NewUser { get; set; } = new User();
        private readonly DataContext context;

        public async Task<IActionResult> OnPostAsync()
        {
            context.Users.Add(NewUser);
            await context.SaveChangesAsync();
            return RedirectToPage("LogIn");
        }
    }
}