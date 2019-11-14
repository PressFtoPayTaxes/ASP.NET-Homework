using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkWithModel.DataAccess;
using WorkWithModel.Models;
using WorkWithModel.ViewModels;

namespace WorkWithModel.Controllers
{
    public class AdminController : Controller
    {
        private UserContext db = new UserContext();

        public ActionResult Index()
        {
            return View(new UserAuthorizationViewModel());
        }
        
        public async Task<ActionResult> CredentialsCheck(FormCollection values)
        {
            var database = await db.Users.ToListAsync();
            foreach (var item in database)
            {
                if(item.UserName == values["UserName"] && item.Password == values["Password"])
                {
                    return Redirect("List");
                }
            }
            return Redirect("Error");
        }

        public ActionResult Error()
        {
            return View();
        }

        // GET: Admin
        public async Task<ActionResult> List()
        {
            List<UserViewModel> database = new List<UserViewModel>();
            var noAdminDatabase = await db.Users.Where(user => user.IsAdmin == false).ToListAsync();

            foreach (var item in noAdminDatabase)
            {
                database.Add(new UserViewModel
                {
                    Id = item.Id,
                    Email = item.Email,
                    Password = item.Password,
                    UserName = item.UserName
                });
            }

            return View(database);
        }

        // GET: Admin/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await db.Users.FindAsync(id);
            UserViewModel viewModel = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email
            };
            if (viewModel == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        // GET: Admin/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Admin/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
