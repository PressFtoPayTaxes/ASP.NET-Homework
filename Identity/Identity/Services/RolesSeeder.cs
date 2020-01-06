using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Services
{
    public class RolesSeeder
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetService(typeof(IdentityContext));

                string[] roles = new string[] { "Doctor", "Customer" };

                foreach (string role in roles)
                {
                    var roleStore = new RoleStore<IdentityRole>(context as DbContext);

                    if (!(context as IdentityContext).Roles.Any(r => r.Name == role))
                    {
                        await roleStore.CreateAsync(new IdentityRole
                        {
                            Name = role,
                            NormalizedName = role.ToUpper()
                        });
                    }
                }
            }
        }
    }
}
