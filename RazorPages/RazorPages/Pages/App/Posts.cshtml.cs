using System;
using System.Collections.Generic;
using System.Linq;
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
    public class PostsModel : PageModel
    {
        private readonly DataContext context;
        private readonly IHttpContextAccessor httpContextAccessor;

        public PostsModel(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
        }

        public List<Post> Posts { get; set; }
        [BindProperty]
        public string NewComment { get; set; }
        public User CurrentUser { get; set; }

        public async Task OnGetAsync()
        {
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                claim => claim.Type == ClaimTypes.NameIdentifier).Value;
            CurrentUser = await context.Users.Include(user => user.LikedPosts).Include(user =>
                user.LikedPosts.LikedPostListPosts).SingleOrDefaultAsync(user => user.Id == Guid.Parse(userId));
            if(CurrentUser.LikedPosts == null)
            {
                CurrentUser.LikedPosts = new LikedPostsList();
                CurrentUser.LikedPosts.LikedPostListPosts = new List<LikedPostsListPost>();
            }
            Posts = await context.Posts.Include(post => post.User).Include(post => post.Comments).ToListAsync();
        }

        public async Task OnPostAsync(string postId)
        {
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                claim => claim.Type == ClaimTypes.NameIdentifier).Value;
            CurrentUser = await context.Users.Include(user => user.LikedPosts).Include(user => 
                user.LikedPosts.LikedPostListPosts).SingleOrDefaultAsync(user => user.Id == Guid.Parse(userId));
            if (CurrentUser.LikedPosts == null)
            {
                CurrentUser.LikedPosts = new LikedPostsList();
                CurrentUser.LikedPosts.LikedPostListPosts = new List<LikedPostsListPost>();
            }
            Posts = await context.Posts.Include(post => post.User).Include(post => post.Comments).ToListAsync();

            var comment = new Comment
            {
                Text = NewComment,
                User = CurrentUser,
                Post = await context.Posts.SingleOrDefaultAsync(post => post.Id == Guid.Parse(postId))
            };

            context.Comments.Add(comment);
            await context.SaveChangesAsync();
        }

        public async Task OnPutLikeAsync(Guid postId, Guid userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.Users.SingleOrDefaultAsync(u => u.Id == userId);

            if(user.LikedPosts == null)
            {
                context.LikedPostsLists.Add(new LikedPostsList
                {
                    UserId = user.Id
                });

                await context.SaveChangesAsync();
            }

            context.LikedPostsListPosts.Add(new LikedPostsListPost
            {
                LikedPostsListId = user.LikedPosts.Id,
                PostId = post.Id
            });
            post.Likes++;
            await context.SaveChangesAsync();
        }

        public async Task OnPutUnlikeAsync(Guid postId, Guid userId)
        {
            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == postId);
            var user = await context.Users.SingleOrDefaultAsync(u => u.Id == userId);

            var deletingEntity = await context.LikedPostsListPosts.SingleOrDefaultAsync(entity => 
                entity.PostId == post.Id && entity.LikedPostsListId == user.LikedPosts.Id);

            context.LikedPostsListPosts.Remove(deletingEntity);

            post.Likes--;
            await context.SaveChangesAsync();
        }
    }
}