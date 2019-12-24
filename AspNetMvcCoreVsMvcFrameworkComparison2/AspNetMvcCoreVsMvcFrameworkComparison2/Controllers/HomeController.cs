using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetMvcCoreVsMvcFrameworkComparison2.Models;
using AspNetMvcCoreVsMvcFrameworkComparison2.DataAccess;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await context.Portfolios.SingleOrDefaultAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}