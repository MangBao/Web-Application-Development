using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp_Book.Areas.Staff.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff/Staff
        public ActionResult Index()
        {
            return View();
        }
    }
}