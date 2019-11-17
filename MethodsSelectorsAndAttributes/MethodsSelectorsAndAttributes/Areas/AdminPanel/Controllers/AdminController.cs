using MethodsSelectorsAndAttributes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MethodsSelectorsAndAttributes.DataAccess;

namespace MethodsSelectorsAndAttributes.Areas.AdminPanel.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminPanel/Admin
        public ActionResult Index()
        {
            return View("Index", new Article());
        }

        public async Task<ActionResult> UploadArticle(FormCollection values)
        {
            using (var context = new NewsContext())
            {
                context.Articles.Add(new Article
                {
                    Header = values["Header"],
                    Text = values["Text"],
                    ImageSource = values["ImageSource"]
                });

                await context.SaveChangesAsync();
            }


            return Redirect("Index");
        }
    }
}