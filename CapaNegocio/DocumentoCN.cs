using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class DocumentoCN
    {
        private static DocumentoDAL docudatos = new DocumentoDAL();
        public static List<Documento> ListarDocumentos()
        {
            return docudatos.ListarDocumentos();
        }

        public static void Agregar(Documento doc)
        {
            string dptorigen = doc.DptoOrigen.Substring(0, 3).ToUpper();
            string dptodestino = doc.DptoDestino.Substring(0, 3).ToUpper();
            doc.Secuencia = ("2021"+"-"+dptorigen+"-"+dptodestino+"-"+doc.IdDocumento+doc.IdUser);        
            docudatos.Agregar(doc);
        }


    }
}
