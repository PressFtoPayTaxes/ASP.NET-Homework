using AspNetMvcCoreVsMvcFrameworkComparison2.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.Services
{
    public class AuthService
    {
        private readonly DataContext context;
        private readonly IHttpContextAccessor httpAccessor;

        public AuthService(DataContext context, IHttpContextAccessor httpAccessor)
        {
            this.context = context;
            this.httpAccessor = httpAccessor;
        }

        public async Task<bool> Authenticate(string login, string password)
        {
            var user = await context.Admins.SingleOrDefaultAsync(x => x.Login == login && x.Password == password);

            if (user == null)
                return false;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = false,
                RedirectUri = "/Admin/Index",
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
            };

            await httpAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

            return true;
        }
    }
}
