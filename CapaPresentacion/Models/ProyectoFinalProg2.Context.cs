//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoFinalProg2Entities : DbContext
    {
        //public ProyectoFinalProg2Entities()
        //    : base("name=ProyectoFinalProg2Entities")
        //{
        //}
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Documento> Documentoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
