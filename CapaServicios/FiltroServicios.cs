using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaServicios
{
    public class FiltroServicios
    {
        ProyectoFinalProg2Entities db = new ProyectoFinalProg2Entities();

        public List<FiltroDptoOrigen_Result> BuscaDptoOrigen(string dptorigen)
        {
        return db.FiltroDptoOrigen(dptorigen).ToList();
    }

        public List<FiltroIDEmpleado_Result> BuscarIDEmp(int id)
        {
            return db.FiltroIDEmpleado(id).ToList();
        }

        public List<FiltroDptoDestino_Result> BuscarDPTdestino(string dptdestino)
        {
            return db.FiltroDptoDestino(dptdestino).ToList();
        }

        public List<FiltroFecha_Result> BuscarFecha(DateTime inicio, DateTime fin)
        {
            return db.FiltroFecha(inicio, fin).ToList();
        }


    }
}
