﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACONSA.Controllers
{
    public class MiCuentaController : Controller
    {
        // GET: MiCuenta
        public ActionResult Login()
        {
            return View();
        }
    }
}