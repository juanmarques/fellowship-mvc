using System;
using System.Web.Mvc;
using fellowship_mvc.Models;

namespace fellowship_mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            //TODO - Consultar banco de dados
            if (login.Email.Equals("1juanmarques@gmail.com") && login.Password.Equals("123456"))
            {
                return RedirectToAction("Index", "Feed");
            }

            return View("Error");
        }
    }
}