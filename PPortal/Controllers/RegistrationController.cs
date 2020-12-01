using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPortal.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index(string id)
        {
            return View();
        }
    }
}