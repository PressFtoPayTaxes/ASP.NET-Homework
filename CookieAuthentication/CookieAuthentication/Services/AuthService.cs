using CookieAuthentication.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookieAuthentication.Services
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
            var user = await context.Users.SingleOrDefaultAsync(u => u.Login == login && u.Password == password);

            if (user == null)
                return false;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.UserData, user.Login),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim("Age", user.Age.ToString()),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = false,
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1),
                RedirectUri = "/Home/Index"
            };

            await accessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), authProperties);

            return true;
        }

    }
}
