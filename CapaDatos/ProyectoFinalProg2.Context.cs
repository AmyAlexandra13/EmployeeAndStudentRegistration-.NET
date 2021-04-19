﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using CapaEntidad;

    public partial class ProyectoFinalProg2Entities : DbContext
    {
        public ProyectoFinalProg2Entities()
            : base("name=ProyectoFinalProg2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Documento> Documentoes { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual ObjectResult<FiltroDptoOrigen_Result> FiltroDptoOrigen(string dpto)
        {
            var dptoParameter = dpto != null ?
                new ObjectParameter("dpto", dpto) :
                new ObjectParameter("dpto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FiltroDptoOrigen_Result>("FiltroDptoOrigen", dptoParameter);
        }
    }
}
