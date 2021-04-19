using CapaNegocio;
using CapaServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class ReportesController : Controller
    {
        FiltroServicios servicio = new FiltroServicios();
        // GET: Reportes
        public ActionResult Reportes()
        {
            return View();
        }

        public ActionResult ReporteUsuario()
        {
            var emps = EmpleadoCN.ListarUsuario();
            return View(emps);
        }


        public ActionResult VerUsuarios(int id)
        {
            var emps = EmpleadoCN.GetUsuario(id);
            return View(emps);
        }

        public ActionResult ReporteDepartamento()
        {
            var dptos = DepartamentoCN.ListaDepartamento();
            return View(dptos);
        }

        public ActionResult VerDepartamento(int id)
        {
            var dptos = DepartamentoCN.GetDepartamento(id);
            return View(dptos);
        }

       public ActionResult ReporteDocumento()
        {
    
            var docs = DocumentoCN.ListarDocumentos();
            return View(docs);
        }

        public ActionResult FiltroDPTOrigen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FiltroOrigenResultado(string dptoorigen)
        {

            return View(servicio.BuscaDptoOrigen(dptoorigen));
        }


       public ActionResult FiltroEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FiltroEmpleadoResultado(int id)
        {
            return View();
            return View(servicio.BuscaDptoOrigen(id));
        }


    }
}