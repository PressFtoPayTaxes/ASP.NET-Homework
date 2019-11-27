using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.DataAccess;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class PostsController : ApiController
    {
        public async Task<HttpResponseMessage> Get()
        {
            List<Post> posts; 
            var dtos = new List<PostDTO>();
            using (var context = new UsersContext())
            {
                posts = await context.Posts.ToListAsync();
                foreach(var post in posts)
                {
                    dtos.Add(new PostDTO
                    {
                        ImageSource = post.ImageSource,
                        Description = post.Description,
                        AuthorName = post.User.Login
                    });
                }
            }

            var response = Request.CreateResponse<IEnumerable<PostDTO>>(HttpStatusCode.OK, dtos);

            return response;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]PostDTO value)
        {
            using (var context = new UsersContext())
            {
                var post = new Post
                {
                    ImageSource = value.ImageSource,
                    Description = value.Description,
                    User = await context.Users.FindAsync(value.User)
                };

                context.Posts.Add(post);
                var user = await context.Users.FindAsync(value.User);
                user.Posts.Add(post);

                await context.SaveChangesAsync();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
