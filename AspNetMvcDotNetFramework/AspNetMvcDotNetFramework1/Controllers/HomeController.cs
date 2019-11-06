using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

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
            SmtpClient client = new SmtpClient("localhost", 2222);
            client.Send("igor_2002_25@mail.ru", email, "Subscribtion", "Congratulations! You subscribed to OneTech shop!");

            return Index();
        }
    }
}