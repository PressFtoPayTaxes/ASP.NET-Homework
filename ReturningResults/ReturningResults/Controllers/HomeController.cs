using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReturningResults.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult DownloadSong()
        {
            //return File("~/audio/Nightmare.mp3", "audio/mp3", "Nightmare.mp3");
            return Json(new { Data = "somedata" });
        }
    }
}