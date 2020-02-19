namespace acfisio.Controllers
{
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

        public ActionResult Servicos()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();

            return View(mw);
        }
    }
}