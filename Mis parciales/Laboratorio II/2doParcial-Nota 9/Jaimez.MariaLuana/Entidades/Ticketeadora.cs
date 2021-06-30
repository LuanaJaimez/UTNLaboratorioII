using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Ticketeadora<T> where T : Utiles
    {
        public static bool ImprimirTicket(Cartuchera<T> car)
        {
            bool retorno = true;

            string ruta = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\tickets.log";

            if (!File.Exists(ruta))
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(ruta, false))
                    {
                        file.Write("Fecha: ");
                        file.WriteLine(System.DateTime.Now);
                        file.Write("Precio Total: ");
                        file.WriteLine(car.PrecioTotal);
                        file.WriteLine("---------------------------------");
                    }
                }
                catch
                {
                    retorno = false;
                }
            }
            else
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(ruta, true))
                    {
                        file.Write("Fecha: ");
                        file.WriteLine(System.DateTime.Now);
                        file.Write("Precio Total: ");
                        file.WriteLine(car.PrecioTotal);
                        file.WriteLine("---------------------------------");
                    }
                }
                catch
                {
                    retorno= false;
                }

            }


            return retorno;
        }
    }
}
