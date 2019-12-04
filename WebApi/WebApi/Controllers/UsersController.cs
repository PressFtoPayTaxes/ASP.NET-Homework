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
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        public async Task<HttpResponseMessage> Get()
        {
            List<User> users;
            using (var context = new UsersContext())
            {
                users = await context.Users.ToListAsync();
            }

            var response = Request.CreateResponse<IEnumerable<User>>(HttpStatusCode.OK, users);

            return response;
        }

        // GET: api/Users/5
        public async Task<HttpResponseMessage> Get(Guid id)
        {
            User user;
            using (var context = new UsersContext())
            {
                user = await context.Users.FindAsync(id);
            }

            var response = Request.CreateResponse<User>(HttpStatusCode.OK, user);

            return response;
        }

        // POST: api/Users
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]User value)
        {
            using (var context = new UsersContext())
            {
                context.Users.Add(new User
                {
                    Login = value.Login,
                    Password = value.Password
                });

                await context.SaveChangesAsync();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
