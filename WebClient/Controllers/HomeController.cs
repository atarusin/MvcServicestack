using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PartsViews(string viewName)
        {
            return View("Parts/" + viewName);
        }

        public ActionResult Page(string viewName)
        {
            return View(viewName);
        }

    }
}
