using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Mail;

namespace MyUmbracoProject
{
    public class EmailSender 
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(subject, htmlMessage, email);
        }
        private Task Execute(string subject, string message, string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("temp@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = message;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("temp@gmail.com", "temp@123");
            SmtpServer.EnableSsl = true;
            return SmtpServer.SendMailAsync(mail);
        }
    }
}
