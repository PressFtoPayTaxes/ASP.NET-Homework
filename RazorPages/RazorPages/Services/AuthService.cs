using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RazorPages.DataAccess;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class AuthService
    {
        private readonly DataContext context;
        private readonly IHttpContextAccessor accessor;

        public AuthService(DataContext context, IHttpContextAccessor accessor)
        {
            this.context = context;
            this.accessor = accessor;
        }

        public async Task<bool> Authenticate(string login, string password)
        {
            var existingUser = await context.Users.FirstOrDefaultAsync(user => user.Login == login &&
                                                                           user.Password == password);
            if(existingUser == null)
            {
                return false;
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, existingUser.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1),
                IsPersistent = true,
                IssuedUtc = DateTime.Now,
                RedirectUri = "/App/Posts"
            };

            await accessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return true;
        }
    }
}
