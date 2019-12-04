using Microsoft.AspNetCore.Http;
using QueryConveyor.DataAccess;
using QueryConveyor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Text;

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
            var splittedPath = context.Request.Path.ToString().Split('/');
            string controllerName = (splittedPath[splittedPath.Length - 1] == "") ?
            splittedPath[splittedPath.Length - 2] : splittedPath[splittedPath.Length - 1];


            StringBuilder builder = new StringBuilder();
            builder.Append("QueryConveyor.Controllers.");
            builder.Append(controllerName.First().ToString().ToUpper());
            builder.Append(controllerName.Substring(1));
            builder.Append("Controller");

            
            var classInfo = Type.GetType(builder.ToString());
            
            try
            {
                if (!Attribute.IsDefined(classInfo, typeof(CustomAuthorize))) { 
                    await requestDelegate(context);
                    return;
                }
            }
            catch (ArgumentNullException)
            {
                await requestDelegate(context);
                return;
            }

            Guid token;
            try
            {
                token = Guid.Parse(context.Request.Headers["AuthorizationToken"].ToString());
            }
            catch (ArgumentNullException)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Authorization Token is missing");
                return;
            }

            var supposedUser = await dbContext.Users.FindAsync(token);
            if (supposedUser == null)
            { 
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Bad Authorization Token");
                return;
            }


            await requestDelegate(context);
        }
    }
}
