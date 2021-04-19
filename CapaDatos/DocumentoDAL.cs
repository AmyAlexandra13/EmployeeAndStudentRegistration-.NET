using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DocumentoDAL
    {
        public List<Documento> ListarDocumentos()
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                return db.Documentoes.ToList();
            }
        }

        public void Agregar(Documento doc)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                db.Documentoes.Add(doc);
                db.SaveChanges();
            }
        }

        public Documento GetDocumento(int id)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                //return db.Departamentoes.Find(id); otra forma de buscar el id del departamento
                return db.Documentoes.Where(d => d.IdDocumento == id).FirstOrDefault();
            }
        }

       


        //public void Editar(Usuario user)
        //{
        //    using (var db = new ProyectoFinalProg2Entities())
        //    {
        //        var u = db.Usuarios.Find(user.Id);
        //        u.Nombre = user.Nombre;
        //        u.Apellido = user.Apellido;
        //        u.Correo = user.Correo;
        //        u.Contra = user.Contra;
        //        u.IdDepartamento = user.IdDepartamento;
        //        u.Cargo = user.Cargo;
        //        db.SaveChanges();
        //    }
        //}


    }
}
