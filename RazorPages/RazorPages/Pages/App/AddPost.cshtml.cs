using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.DataAccess;
using RazorPages.Models;

namespace RazorPages.Pages.App
{
    [Authorize]
    public class AddPostModel : PageModel
    {
        private readonly DataContext context;
        private readonly IHttpContextAccessor httpContextAccessor;

        [BindProperty]
        public string ImageUrl { get; set; }
        [BindProperty]
        public string Description { get; set; }

        public AddPostModel(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            string filePath = $"wwwroot/posts-images/{Guid.NewGuid()}";

            using (var client = new WebClient())
            {
                await client.DownloadFileTaskAsync(ImageUrl, filePath);
            }

            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                claim => claim.Type == ClaimTypes.NameIdentifier).Value;

            context.Posts.Add(new Post
            {
                ImageUrl = filePath,
                Description = Description,
                Likes = 0,
                User = await context.Users.SingleOrDefaultAsync(user => user.Id == Guid.Parse(userId))
            });

            await context.SaveChangesAsync();

            return RedirectToPage("Posts");
        }
    }
}