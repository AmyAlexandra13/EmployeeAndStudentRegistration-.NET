using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Departamento()
        {
            var dptos = DepartamentoCN.ListaDepartamento();
            return View(dptos);
        }

        public ActionResult Crear()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Departamento dpto)
        {
            //var dptos = DepartamentoCN.Agregar(dpto);
            try
            {
                if(dpto.Nombre == null && dpto.Siglas == null)
                {
                    ModelState.AddModelError("", "Debe llenar todos los campos");
                    return View(dpto);
                }
                DepartamentoCN.Agregar(dpto);
                return RedirectToAction("Departamento");
            }
            catch (Exception ex)
            {
                //ex.Message("No se pudo agregar el departamento");
                ModelState.AddModelError("", "Ocurrio un error al agregar el departamento");
                return View(dpto);
            }
            
        }

        public ActionResult Editar(int id)
        {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);
        }


        [HttpPost]
        public ActionResult Editar(Departamento dpto)
        {
            try
            {
                DepartamentoCN.Editar(dpto);
                return RedirectToAction("Departamento");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al editar el departamento");
                return View(dpto);
            }
            
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = DepartamentoCN.GetDepartamento(id.Value);
            return View(dpto);
        }


        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                DepartamentoCN.Eliminar(id);
                return RedirectToAction("Departamento");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al eliminar el departamento");
                return View(id);

            }
        }



    }
}