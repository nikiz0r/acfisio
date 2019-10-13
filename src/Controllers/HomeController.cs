namespace acfisio.Controllers
{
    using System.Web.Mvc;
    using Helpers;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(BannerHelper.GetBanners());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}