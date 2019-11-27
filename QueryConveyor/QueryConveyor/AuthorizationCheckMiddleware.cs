using Microsoft.AspNetCore.Http;
using QueryConveyor.DataAccess;
using QueryConveyor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryConveyor
{
    public class AuthorizationCheckMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly UsersContext dbContext;

        public AuthorizationCheckMiddleware(RequestDelegate requestDelegate, UsersContext dbContext)
        {
            this.requestDelegate = requestDelegate;
            this.dbContext = dbContext;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                var token = Guid.Parse(context.Request.Headers["AuthorizationToken"].ToString());
                if(await dbContext.FindAsync<User>(token) == null)
                {
                }
            }
            catch (ArgumentNullException)
            {

            }

            await requestDelegate(context);
        }
    }
}
