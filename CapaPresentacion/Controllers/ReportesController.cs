using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class ReportesController : Controller
    {
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



    }
}