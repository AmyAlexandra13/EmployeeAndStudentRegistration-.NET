using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EmpleadoDAL
    {
        public List<Usuario> ListarUsuario()
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                return db.Usuarios.ToList();
            }
        }

        public void Agregar(Usuario user)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                db.Usuarios.Add(user);
                db.SaveChanges();
            }
            }

        public Usuario GetUsuario (int id)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                //return db.Usuarios.Find(id); una forma de buscar el id
                return db.Usuarios.Where(u => u.Id == id).FirstOrDefault();
              
            }
        }

        public void Editar(Usuario user)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                var u = db.Usuarios.Find(user.Id);
                u.Nombre = user.Nombre;
                u.Apellido = user.Apellido;
                u.Correo = user.Correo;
                u.Contra = user.Contra;
                u.IdDepartamento = user.IdDepartamento;
                u.Cargo = user.Cargo;
                db.SaveChanges();
            }
        }

       
        public void Eliminar(int id)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                var user = db.Usuarios.Find(id);
                db.Usuarios.Remove(user);
                db.SaveChanges();

            }
        }



    }
}
