﻿namespace acfisio.Controllers
{
    using System.Configuration;
    using System.Net;
    using System.Net.Mail;
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mw = new ModelWrapper()
                .WithBanners()
                .WithMenu()
                .Build();
            
            return View(mw);
        }

        public ActionResult Contato()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();

            return View(mw);
        }

        public ActionResult Atendimentos()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();

            return View(mw);
        }

        [HttpPost]
        public ActionResult Contato(ContatoModel contato)
        {
            string username = ConfigurationManager.AppSettings["username"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            string emailfrom = "contato@topfrutti.com.br";
            string emailTo = "contato@topfrutti.com.br";
            string fromName = "Top Frutti";
            string subject = "Top Frutti - Contato";

            string template = System.IO.File.ReadAllText(Server.MapPath("~/Content/template/contato.html"));
            template = template.Replace("#NOME#", contato.name);
            template = template.Replace("#EMAIL#", contato.email);
            template = template.Replace("#TELEFONE#", contato.phone);
            template = template.Replace("#MENSAGEM#", contato.message);

            var client = new SmtpClient("email-smtp.us-east-1.amazonaws.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(username, password),
            };

            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(emailfrom, fromName);
            message.To.Add(new MailAddress(emailTo));
            message.Subject = subject;
            message.Body = template;

            client.Send(message);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}