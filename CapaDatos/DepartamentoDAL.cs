using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DepartamentoDAL
    {
        public void Agregar(Departamento dpto)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                db.Departamentoes.Add(dpto);
                db.SaveChanges();
            }
        }
     
        public List<Departamento> ListaDepartamento()
        {
           using (var db = new ProyectoFinalProg2Entities())
            {
                return db.Departamentoes.ToList();

            }
        }

        public Departamento GetDepartamento(int id)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                //return db.Departamentoes.Find(id); otra forma de buscar el id del departamento
                return db.Departamentoes.Where(d => d.IdDpt == id).FirstOrDefault();
            }
        }

        public void Editar(Departamento dpto)
        {
            using (var db = new ProyectoFinalProg2Entities())
            {
                var d = db.Departamentoes.Find(dpto.IdDpt);
                d.Nombre = dpto.Nombre;
                d.Siglas = dpto.Siglas;
                db.SaveChanges();
            }
        }
        
        public void Eliminar(int id)
        {
            using (var db= new ProyectoFinalProg2Entities())
            {
                var dpto = db.Departamentoes.Find(id);
                db.Departamentoes.Remove(dpto);
                db.SaveChanges();
                   
            }
        }
    }
}
