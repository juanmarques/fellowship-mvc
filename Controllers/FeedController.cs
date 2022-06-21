using System.Web.Mvc;

namespace fellowship_mvc.Controllers
{
    public class Feed : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}