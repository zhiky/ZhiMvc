﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LazyMvcZhi.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Del()
        {
            return View();
        }
    }
}