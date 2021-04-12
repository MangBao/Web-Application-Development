using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DangkyNV.Models;

namespace DangkyNV.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Confirm(HttpPostedFileBase Avatar, EmpModel emp)
        {
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(Avatar.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("~/Images/" + postedFileName);
            Avatar.SaveAs(path);
            string fSave = Server.MapPath("~/Data/emp.txt");
            string[] emInfo = {
                emp.EmpID, emp.Name, 
                emp.BirthOfDate.ToShortDateString(), 
                emp.Email,emp.Password,emp.Department, 
                postedFileName
            };
            //Lưu các thông tin vào tập tin emp.txt
            System.IO.File.WriteAllLines(fSave, emInfo);
            //Ghi nhận các thông tin đăng ký để hiện thị trên View Confirm
            ViewBag.EmpID = emInfo[0];
            ViewBag.Name = emInfo[1];
            ViewBag.BirthOfDate = emInfo[2].ToString();
            ViewBag.Email = emInfo[3];
            ViewBag.Password = emInfo[4];
            ViewBag.Department = emInfo[5];
            ViewBag.Avatar = "/Images/" + emInfo[6];
            return View();
            /*
             * File() hiển thị source code
             * di chuyển từ trang web này sang trang web khác RedirectAction()
             * tham số trong request là name hoặc tên biến ở model
             * 
            */
        }
        /*public ActionResult Confirm(EmpModel emp)
        {
            return View();
        }*/
    }
}