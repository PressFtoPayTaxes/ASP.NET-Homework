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
    public class UsersController : ApiController
    {
        // GET: api/Users
        public async Task<IEnumerable<User>> Get()
        {
            List<User> users;
            using (var context = new UserContext())
            {
                users = await context.Users.ToListAsync();
            }

            return users;
        }

        // GET: api/Users/5
        public async Task<User> Get(Guid id)
        {
            User user;
            using (var context = new UserContext())
            {
                user = await context.Users.FindAsync(id);
            }
            return user;
        }

        // POST: api/Users
        public async void Post([FromBody]User value)
        {
            using (var context = new UserContext())
            {
                context.Users.Add(new User
                {
                    Login = value.Login,
                    Password = value.Password
                });

                await context.SaveChangesAsync();
            }
        }

    }
}
