using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaServicios;

namespace CapaPresentacion.Controllers
{
    public class FiltrosController : Controller
    {
        // GET: Filtros
        FiltroServicios servicio = new FiltroServicios();
        public ActionResult FiltroDPTOrigen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FiltroOrigenResultado(string dptoorigen)
        {

            return View(servicio.BuscaDptoOrigen(dptoorigen));
        }

      


    }
}