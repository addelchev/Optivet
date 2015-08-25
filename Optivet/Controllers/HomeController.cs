using Optivet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Optivet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var model = new ImageSliderModel();
            model.images.Add(new Image { ImagePath = "~/Content/SiteImages/p1.png"});
            model.images.Add(new Image { ImagePath = "~/Content/SiteImages/p2.png" });
            model.images.Add(new Image { ImagePath = "~/Content/SiteImages/p3.png" });
            model.images.Add(new Image { ImagePath = "~/Content/SiteImages/p4.png" });

            //var getAllImage = contextObj.gallery.ToList();
            return View(model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Faq()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
