using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DepartamentoCN
    {
        private static DepartamentoDAL dptodatos = new DepartamentoDAL();

        public static void Agregar(Departamento dpto)
        {
            dptodatos.Agregar(dpto);
        }


        public static List<Departamento> ListaDepartamento()
        {
            return dptodatos.ListaDepartamento();
        }

        public static Departamento GetDepartamento(int id)
        {
            return dptodatos.GetDepartamento(id);
        }

        public static void Editar(Departamento dpto)
        {
            dptodatos.Editar(dpto);
        }

        public static void Eliminar(int id)
        {
            dptodatos.Eliminar(id);
        }
    }
}