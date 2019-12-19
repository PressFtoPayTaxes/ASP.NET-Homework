using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.DataAccess;

namespace RazorPages.Pages.App
{
    [Authorize]
    public class AddPostModel : PageModel
    {
        private readonly DataContext context;
        private readonly HttpContext httpContext;



        public AddPostModel(DataContext context, HttpContext httpContext)
        {
            this.context = context;
            this.httpContext = httpContext;
        }

        public void OnGet()
        {

        }
    }
}