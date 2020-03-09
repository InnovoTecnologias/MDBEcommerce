using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBEcommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.RenderCarousel = true;
            return View();
        }

        public ActionResult Product()
        {
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Checkout()
        {
            ViewBag.RenderCarousel = false;
            return View();
        }
    }
}