using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACONSA.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bordados()
        {
            return View("../Bordados/Index");
        }
        public ActionResult Produccion()
        {
            return View("../Produccion/Index");
        }
    }
}