using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public static class Texto 
    {
        public static bool Guardar(string archivo, string datos)
        {
            try
            {
               using (StreamWriter writer = new StreamWriter(archivo, true))
               {
                   writer.WriteLine("Error: " + datos.ToString());
               }
               return true;    
            }
            catch (Exception ex)
            {
                throw new ArchivoException(ex.Message, ex);
            }
        }

    }//
}//
