using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FinalProjectFirstTest.Controllers
{
    public class sendEmailController : Controller
    {
        public ActionResult SendMail()
        {
            var mails = new string[] { "tfm10405@gmail.com" }; // 寄給誰

            var mailhelper = new MailHelper();
            mailhelper.CreateMail(mails, "測試", "<h1>Hello</h1>");
            mailhelper.Send();

            return Content("寄信成功");
        }

        private class MailHelper
        {
            private MailMessage mail;
            private readonly SmtpClient client;

            public MailHelper()
            {
                client = new SmtpClient("smtp.gmail.com", 587);
            }
            public MailHelper(MailMessage mail)
            {
                client = new SmtpClient("smtp.gmail.com", 587);
                this.mail = mail;
            }

            public bool Send()
            {
                client.Credentials = new System.Net.NetworkCredential("tfm10405@gmail.com", "aA870211");
                client.EnableSsl = true;
                client.Send(mail);
                return true;
            }

            public void CreateMail(string[] to, string subject, string body)
            {
                var mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("tfm10405@gmail.com");
                foreach (var item in to)
                {
                    mail.To.Add(item);
                }
                mail.Subject = subject;
                mail.Body = body;

                this.mail = mail;
            }
        }
    }
}
