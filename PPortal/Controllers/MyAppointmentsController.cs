using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPortal.Controllers
{
    public class MyAppointmentsController : Controller
    {
        // GET: MyAppointments
        public ActionResult Index()
        {
            return View();
        }
    }
}