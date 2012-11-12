using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FishingGuideSanbox.Controllers
{
    public class GalleryController : Controller
    {
        //
        // GET: /Content/

        public ActionResult Index()
        {
            return PartialView();
        }

    }
}
