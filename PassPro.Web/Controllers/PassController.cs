﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassPro.Web.Controllers
{
    public class PassController : Controller
    {
        // GET: Pass
        public ActionResult Index()
        {
            return View();
        }
    }
}