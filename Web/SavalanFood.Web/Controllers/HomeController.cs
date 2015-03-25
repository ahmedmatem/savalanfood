namespace SavalanFood.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using SavalanFood.Models;
    using SavalanFood.Data;
    using SavalanFood.Common;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var product = new Product()
            //{
            //    Name = "Soleti",
            //};

            //var context = new ApplicationDbContext();
            //context.Products.Add(product);
            //context.SaveChanges();

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
    }
}