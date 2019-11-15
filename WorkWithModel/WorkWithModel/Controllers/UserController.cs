using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WorkWithModel.DataAccess;
using WorkWithModel.Models;
using WorkWithModel.ViewModels;

namespace WorkWithModel.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(new UserAuthorizationViewModel());
        }

        public async Task<ActionResult> CredentialsCheck(FormCollection values)
        {
            using (var context = new UserContext())
            {
                var database = await context.Users.Where(user => user.IsAdmin == false).ToListAsync();
                foreach (var item in database)
                {
                    if(values["UserName"] == item.UserName && values["Password"] == item.Password)
                    {
                        return Redirect("News");
                    }
                }
                return Redirect("Error");
            }
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View(new UserViewModel());
        }

        public async Task<ActionResult> Create(FormCollection values)
        {
            using (var context = new UserContext())
            {
                context.Users.Add(new Models.User
                {
                    UserName = values["UserName"],
                    Password = values["Password"],
                    Email = values["Email"]
                });

                await context.SaveChangesAsync();
            }

            return Redirect("News");
        }

        public async Task<ActionResult> News()
        {
            List<Article> articles;
            using (var context = new ArticleContext())
            {
                articles = await context.News.ToListAsync();
            }

            return View(articles);
        }
    }
}
