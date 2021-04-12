using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendMail.Models;

namespace SendMail.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MailInfo model)
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
            return RedirectToAction("Index", "Index");
        }
    }
}