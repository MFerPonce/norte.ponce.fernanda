using System.Web.Mvc;

namespace Ejercicio.Maquetado.Controllers
{
    public class HomeController : Controller
    {
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