using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryConveyor
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorizationCheck(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationCheckMiddleware>();
        }
    }
}
