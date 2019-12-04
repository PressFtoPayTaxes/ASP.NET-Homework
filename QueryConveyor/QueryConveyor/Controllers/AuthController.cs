using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueryConveyor.DataAccess;
using QueryConveyor.DTOs;
using QueryConveyor.Models;

namespace QueryConveyor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UsersContext context;

        public AuthController(UsersContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Registrate(User user)
        {
            user.AuthorizationToken = Guid.NewGuid();
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return Ok(new { user.AuthorizationToken });
        }

        [HttpGet]
        public IActionResult LogIn(LogInDTO dto)
        {
            foreach (var item in context.Users)
            {
                if(item.Login == dto.Login && item.Password == dto.Password)
                {
                    return Ok(new { item.AuthorizationToken });
                }
            }

            return BadRequest();
        }
    }
}