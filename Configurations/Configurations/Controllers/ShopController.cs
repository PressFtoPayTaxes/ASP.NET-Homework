using System;
using System.Linq;
using System.Threading.Tasks;
using Configurations.DataAccess;
using Configurations.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Configurations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ShopContext context;
        private readonly IPaymentService paymentService;

        public ShopController(ShopContext context, IPaymentService paymentService)
        {
            this.context = context;
            this.paymentService = paymentService;
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
        public async Task<IActionResult> Pay(Guid id)
        {
            var basket = await context.Baskets.Where(basket => basket.User.Id == id).FirstAsync();

            var paymentId = await paymentService.MakePayment(basket);

            return Ok(paymentId);
        }
    }
}
