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
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Empleados()
        {
            var emps = EmpleadoCN.ListarUsuario();
            return View(emps);

        }

        public ActionResult Crear()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Usuario user)
        {
            try
            {
                if (user.Nombre == null || user.Apellido == null || user.Correo == null ||
                    user.Contra == null || user.IdDepartamento == null || user.Cargo == null)
                {
                    ModelState.AddModelError("", "Debe llenar todos los campos");
                    return View(user);
                }
                EmpleadoCN.Agregar(user);
                return RedirectToAction("Empleados");
            }
            catch (Exception ex)
            {
                //ex.Message("No se pudo agregar el departamento");
                ModelState.AddModelError("", "Ocurrio un error al agregar el Empleado");
                return View(user);
            }

        }



        public ActionResult Editar(int id)
        {
            var user = EmpleadoCN.GetUsuario(id);
            return View(user);
        }


        [HttpPost]
        public ActionResult Editar(Usuario user)
        {
            try
            {
                EmpleadoCN.Editar(user);
                return RedirectToAction("Empleados");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al editar el empleado");
                return View(user);

            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var user = EmpleadoCN.GetUsuario(id.Value);
            return View(user);
        }


        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                EmpleadoCN.Eliminar(id);
                return RedirectToAction("Empleados");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al eliminar el empleado");
                return View(id);

            }
        }



    }
}