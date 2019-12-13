using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppEkaS2019.Models;
using System.Web.Mvc;

namespace WebAppEkaS2019.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            northwindEntities db = new northwindEntities();
            List<Products> tuotteet = db.Products.ToList();
            db.Dispose();
            return View(tuotteet);
        }
    }
}