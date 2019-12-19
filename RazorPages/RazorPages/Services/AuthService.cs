using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RazorPages.DataAccess;
using RazorPages.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class AuthService
    {
        private readonly DataContext context;
        private readonly string secret;
        private readonly string audience;
        private readonly string issuer;

        public AuthService(DataContext context, IOptions<AuthenticationSecretOptions> secret, 
                               IOptions<ValidAudienceOptions> audience, IOptions<ValidIssuerOptions> issuer)
        {
            this.context = context;
            this.secret = secret.Value.Secret;
            this.audience = audience.Value.Audience;
            this.issuer = issuer.Value.Issuer;
        }

        public async Task<string> Authenticate(string login, string password)
        {
            var existingUser = await context.Users.FirstOrDefaultAsync(user => user.Login == login &&
                                                                           user.Password == password);
            if(existingUser == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, existingUser.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
