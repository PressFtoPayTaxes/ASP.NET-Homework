using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.DataAccess;
using RazorPages.Models;

namespace RazorPages.Pages.App
{
    [Authorize]
    public class AddPostModel : PageModel
    {
        private readonly DataContext context;
        private readonly HttpContext httpContext;

        public string FilePath { get; set; }
        public string Description { get; set; }

        public AddPostModel(DataContext context, HttpContext httpContext)
        {
            this.context = context;
            this.httpContext = httpContext;
        }


        public void OnPost()
        {
            string fileName = FilePath.Split('/')[^0];
            string filePath = $"~/post-images/{fileName}";
            System.IO.File.Replace(FilePath, filePath, $"~/backups/{fileName}");

            context.Posts.Add(new Post
            {
                ImageUrl = filePath,
                Description = Description,
                Likes = 0,
                User = 
            })
        }
    }
}