using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DangkyTTSV.Models;

namespace DangkyTTSV.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //Dùng model
        /*public ActionResult Index2(SignUp signUp)
        {
            ViewBag.Id = signUp.Id;
            ViewBag.Name = signUp.Name;
            ViewBag.Score = signUp.Score;

            return View();
        }*/
        //Dùng FormCollection
        /*public ActionResult Index2(FormCollection f)
        {
            ViewBag.Id = f["Id"];
            ViewBag.Name = f["Name"];
            ViewBag.Score = f["Score"];

            return View();
        }*/
        //Dùng đối số của action
        /*public ActionResult Index2(string Id, string Name, int Score)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Score = Score;

            return View();
        }*/
        //Dùng Request
        public ActionResult Index2()
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Score = Request["Score"];

            return View();
        }
    }
}