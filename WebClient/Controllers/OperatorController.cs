﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class OperatorController : Controller
    {
        public ActionResult Page(string viewName)
        {
            return View(viewName);
        }
    }
}
