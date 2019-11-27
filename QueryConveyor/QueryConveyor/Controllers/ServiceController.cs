using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueryConveyor.DataAccess;

namespace QueryConveyor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            

            
        }

    }
}