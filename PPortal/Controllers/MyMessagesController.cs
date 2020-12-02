using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPortal.Controllers
{
    public class MyMessagesController : Controller
    {
        // GET: MyMessages
        public ActionResult Index()
        {
            return View();
        }
    }
}