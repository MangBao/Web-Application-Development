using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTLayout.Models;

namespace BTLayout.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {            
            return View();
        }
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Confirm(HttpPostedFileBase Avatar, EmpModel emp)
        {
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(Avatar.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("~/Assets/Img/" + postedFileName);
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
            ViewBag.Avatar = "/Assets/Img/" + emInfo[6];
            return View();
            /*
             * File() hiển thị source code
             * di chuyển từ trang web này sang trang web khác RedirectAction()
             * tham số trong request là name hoặc tên biến ở model
             * 
            */
        }
        public ActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMail(MailInfo model)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(model.From);
            mail.To.Add(model.To);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
            /*
             * Mail bị spam sẽ chặn 
             */
            smtp.EnableSsl = true;
            smtp.Send(mail);

            smtp.UseDefaultCredentials = false;
            return RedirectToAction("Index", "Index/SendMail");
        }

        public ActionResult ChangeBanner()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult ChangeBanner(HttpPostedFileBase bannerName, GetIMG getIMG)
        {
            
            string postedFileName = System.IO.Path.GetFileName(bannerName.FileName);
            //Lưu hình đại diện về Server
            var path = System.Web.Hosting.HostingEnvironment.MapPath("~/Assets/Img/" + postedFileName);
            bannerName.SaveAs(path);
            string fSave = Server.MapPath("/banner.txt");
            string[] img = {                
                postedFileName
            };
            System.IO.File.WriteAllLines(fSave, img);
            ViewBag.image = "/Assets/Img/" + postedFileName;

            return RedirectToAction("Index","Index/ChangeBanner");
        }
    }
}