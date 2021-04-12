using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebApp_Book.Controllers;


namespace DemoWebApp_Book.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return Index();
        }
    }
}