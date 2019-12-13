using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppEkaS2019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Laskuri()
        {
            string apumuuttuja= "";
            for (int i = 0; i < 10; i++)
            {
                apumuuttuja = apumuuttuja + "Laskurin arvo on nyt " + i.ToString();
            }
            ViewBag.Message = apumuuttuja;
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}
