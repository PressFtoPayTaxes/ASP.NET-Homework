using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configurations.DataAccess;
using Configurations.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Configurations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ShopContext context;

        public ShopController(ShopContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var basket = await context.Baskets.Where(basket => basket.User.Id == id).FirstAsync();

            return Ok(basket);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductDTO product)
        {
            var basket = await context.Baskets.Where(basket => basket.User.Id == product.User).FirstAsync();

            var someProduct = await context.Products.FindAsync(product.Product);

            basket.Products.Add(someProduct);
            basket.Bill += someProduct.Price;
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpOptions]
        public async Task<IActionResult> Options(Guid id)
        {
            
        }
    }
}
