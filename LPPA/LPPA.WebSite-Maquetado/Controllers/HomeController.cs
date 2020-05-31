using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA.WebSite_Maquetado.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "La página de descripción de su aplicación.";
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Su página de contacto.";
            return View();
        }
    }
}