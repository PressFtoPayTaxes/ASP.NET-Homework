using MethodsSelectorsAndAttributes.DataAccess;
using MethodsSelectorsAndAttributes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MethodsSelectorsAndAttributes.Areas.NewsArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: NewsArea/Home
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
        public async Task<ActionResult> UpdateNews()
        {
            List<Article> articles;
            using(var context = new NewsContext())
            {
                articles = await context.Articles.ToListAsync();
            }

            return Json(articles, JsonRequestBehavior.AllowGet);
        }
    }
}