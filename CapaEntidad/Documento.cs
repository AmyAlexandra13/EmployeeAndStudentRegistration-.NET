//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documento
    {
        public int IdDocumento { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string TipoDocumento { get; set; }
        public string DptoOrigen { get; set; }
        public string DptoDestino { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Secuencia { get; set; }
    }
}