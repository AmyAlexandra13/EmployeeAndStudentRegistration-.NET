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




    }
}
