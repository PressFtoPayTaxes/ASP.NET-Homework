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
            if (user == null)
            {
                return HttpNotFound();
            }
            UserViewModel viewModel = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email
            };
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
            UserViewModel viewModel = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email
            };
            return View(viewModel);
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
            UserViewModel viewModel = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email
            };
            return View(viewModel);
        }

        public async Task<ActionResult> UpdateUser(FormCollection values)
        {
            using (var context = new UserContext())
            {
                var id = Guid.Parse(values["Id"]);
                var user = await context.Users.Where(item => item.Id == id).ToListAsync();
                user[0].UserName = values["UserName"];
                user[0].Password = values["Password"];
                user[0].Email = values["Email"];

                await context.SaveChangesAsync();
            }

            return Redirect("List");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            using (var context = new UserContext())
            {
                var user = await context.Users.FindAsync(id);
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }

            return RedirectToAction("List");
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
