using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.DataAccess;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PostsController : ApiController
    {
        // GET: api/Posts
        public async Task<IEnumerable<Post>> Get()
        {
            List<Post> posts;
            using (var context = new UserContext())
            {
                posts = await context.Posts.ToListAsync();
            }

            return posts;
        }

        // GET: api/Users/5
        public async Task<Post> Get(Guid id)
        {
            Post post;
            using (var context = new UserContext())
            {
                post = await context.Posts.FindAsync(id);
            }
            return post;
        }

        // POST: api/Users
        public async void Post([FromBody]Post value)
        {
            using (var context = new UserContext())
            {
                var post = new Post
                {
                    ImageSource = value.ImageSource,
                    Description = value.Description,
                    User = value.User
                };

                context.Posts.Add(post);
                var user = await context.Users.FindAsync(value.User.Id);
                user.Posts.Add(post);

                await context.SaveChangesAsync();
            }
        }
    }
}
