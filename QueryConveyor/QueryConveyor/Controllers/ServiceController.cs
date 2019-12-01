using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueryConveyor.DataAccess;
using QueryConveyor.Models;

namespace QueryConveyor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthorize]
    public class ServiceController : ControllerBase
    {
        private readonly UsersContext context;

        public ServiceController(UsersContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile()
        {
            var user = await context.FindAsync<User>(Guid.Parse(Request.Headers["AuthorizationToken"].ToString()));

            return Ok(user);
        }

    }
}