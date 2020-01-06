using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IdentityContext context;

        public HomeController(ILogger<HomeController> logger, IdentityContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [Authorize(Roles = "Customer")]
        [Route("/Home/CustomersPage")]
        public async Task<IActionResult> CustomersPage()
        {
            var currentUser = await context.Customers.Include(user => user.Orders).FirstOrDefaultAsync(user => user.UserName == User.Identity
                .Name);
            if (currentUser.Orders == null)
                return View(new List<Order>());
            else
            {
                var orders = await context.Orders.Include(order => order.Doctor).Where(order => order.Customer == currentUser).ToListAsync();
                return View(orders);
            }
        }
        
        [Authorize(Roles = "Doctor")]
        [Route("/Home/DoctorsPage")]
        public async Task<IActionResult> DoctorsPage()
        {
            var currentUser = await context.Doctors.Include(user => user.Orders).FirstOrDefaultAsync(user => user.UserName == User.Identity
                .Name);

            if (currentUser.Orders == null)
                return View(new List<Order>());
            else
            {
                var orders = await context.Orders.Include(order => order.Customer).Where(order => order.Doctor == currentUser).ToListAsync();
                return View(orders);
            }
        }

        [HttpPost]
        [Route("/Home/MakeOrder")]
        public async Task<IActionResult> MakeOrder(string doctorName, string inquiryName)
        {
            var currentUser = await context.Customers.FirstOrDefaultAsync(user => user.UserName == User.Identity
                .Name);
            var doctor = await context.Doctors.FirstOrDefaultAsync(doc => doc.UserName == doctorName);

            context.Orders.Add(new Order
            {
                InquiryName = inquiryName,
                Customer = currentUser,
                Doctor = doctor
            });

            await context.SaveChangesAsync();

            return Redirect("/Home/CustomersPage");
        }

        [HttpPost]
        [Route("/Home/ApplyOrder")]
        public async Task<IActionResult> ApplyOrder(Guid orderId)
        {
            var order = await context.Orders.SingleOrDefaultAsync(ord => ord.Id == orderId);
            context.Orders.Remove(order);
            await context.SaveChangesAsync();

            return Redirect("/Home/DoctorsPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
