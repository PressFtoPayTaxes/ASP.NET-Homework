using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace AspNetMvcDotNetFramework1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string email)
        {
            SmtpClient client = new SmtpClient("smtp.mail.ru", 25);
            client.Credentials = new NetworkCredential("igor_2002_25@mail.ru", "********************");
            client.EnableSsl = true;
            client.Send("igor_2002_25@mail.ru", email, "Subscribtion", "Congratulations! You subscribed to OneTech shop!");

            return Index();
        }
    }
}
