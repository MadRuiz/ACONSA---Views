using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACONSA.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CRF()
        {
            return View("Credito_Fiscal");
        }
        public ActionResult COF()
        {
            return View("Consumidor_Final");
        }
        public ActionResult NR()
        {
            return View("Nota_Remision");
        }
        public ActionResult NDF()
        {
            return View("Nota_Credito_Fiscal");
        }
        public ActionResult NCF()
        {
            return View("Nota_Debito_Fiscal");
        }
    }
}