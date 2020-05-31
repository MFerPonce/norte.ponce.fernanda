using LPPA.WebSite.Models;
using System;
using System.Web.Mvc;

namespace LPPA.WebSite.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            var cliente = new Cliente();

            cliente.Nombre = form["nombre"];
            cliente.DNI = Convert.ToInt32(form["dni"]);
            cliente.Sexo = form["sexo"];
            cliente.FechaNac = Convert.ToDateTime(form["fnac"]);

            DominioCliente.Add(cliente);

            return RedirectToAction("Index");
        }
    }
}