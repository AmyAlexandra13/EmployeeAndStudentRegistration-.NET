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
            
            return View(servicio.BuscarIDEmp(id));
        }


        public ActionResult FiltroDPTDestino()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FiltroDestinoResultado(string dptdestino)
        {
            
            return View(servicio.BuscarDPTdestino(dptdestino));
        }


        public ActionResult FiltroFecha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FiltroFechaResultado(DateTime inicio1, DateTime fin1)
        {
            return View(servicio.BuscarFecha(inicio1,fin1));
        }


    }
}