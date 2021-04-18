

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        ProyectoFinalProg2Entities db = new ProyectoFinalProg2Entities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario cuenta)
        {
            var user = db.Usuarios.Where(x => x.Id == cuenta.Id && x.Contra == cuenta.Contra).Count();
            if (user > 0)
            {
                return RedirectToAction("Menu");
            }
            else
            {
                return View();
            }
           
        }

        public ActionResult Menu() //Vista del menu
        {
            return View();
        }
    }
}