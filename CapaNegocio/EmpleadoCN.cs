using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EmpleadoCN
    {
        private static EmpleadoDAL empdatos = new EmpleadoDAL();
        public static List<Usuario> ListarUsuario()
        {
            return empdatos.ListarUsuario();
        }

        public static void Agregar(Usuario user)
        {
            empdatos.Agregar(user);
        }

        public static Usuario GetUsuario(int id)
        {
            return empdatos.GetUsuario(id);
        }

        public static void Editar(Usuario user)
        {
            empdatos.Editar(user);
        }

        public static void Eliminar(int id)
        {
            empdatos.Eliminar(id);
        }
    }
}
