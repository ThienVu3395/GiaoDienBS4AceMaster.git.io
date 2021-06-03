using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedlineWorld.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AuthLogin()
        {
            return View();
        }
    }
}