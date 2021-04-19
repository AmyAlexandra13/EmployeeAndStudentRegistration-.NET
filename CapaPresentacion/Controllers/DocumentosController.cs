using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class DocumentosController : Controller
    {
        // GET: Documentos
        public ActionResult Documentos()
        {
            var docs = DocumentoCN.ListarDocumentos();
            return View(docs);
           
        }

        public ActionResult CrearDocumento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearDocumento(Documento doc)
        {
            DocumentoCN.Agregar(doc);
           return RedirectToAction("Documentos");
        }

    }
}