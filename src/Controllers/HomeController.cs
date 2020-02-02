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

        public ActionResult Ortopedica()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();
            
            return View(mw);
        }
        
        public ActionResult Aquatica()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();
            
            return View(mw);
        }
        
        public ActionResult Senior()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();
            
            return View(mw);
        }
        
        public ActionResult DryNeedling()
        {
            var mw = new ModelWrapper()
                .WithMenu()
                .Build();
            
            return View(mw);
        }
    }
}