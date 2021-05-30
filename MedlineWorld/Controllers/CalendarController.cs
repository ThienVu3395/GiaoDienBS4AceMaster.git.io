using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedlineWorld.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index() // MedlineWorld
        {
            return View();
        }
        public ActionResult MedlineVN()
        {
            return View();
        }
        public ActionResult Manage()
        {
            return View();
        }
    }
}