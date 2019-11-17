using IntroductionInRazor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroductionInRazor.Controllers
{
    public class WallController : Controller
    {
        // GET: Wall
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                ViewData["Posts"] = context.Posts.ToList();
            }
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(string author, string text)
        {
            using (var context = new DataContext())
            {
                context.Posts.Add(new Models.Post()
                {
                    Author = author,
                    Text = text
                });

                context.SaveChanges();
            }

            //return View("Index");
            return Json(new { message = "OK" });
        }

        public ActionResult GetData()
        {
            using (var context = new DataContext())
            {
                return Json(context.Posts.ToList(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}