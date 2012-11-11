using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FishingGuideSanbox.Models;

namespace FishingGuideSanbox.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return PartialView();
        }
        public ActionResult HomePage()
        {
            return PartialView();
        }
        public ActionResult GetNavigationLinks()
        {
            NavigationLinkRepository nlr = new NavigationLinkRepository();

            return PartialView("NavigationLinks",nlr.GetLinks());
        }
    }
}
