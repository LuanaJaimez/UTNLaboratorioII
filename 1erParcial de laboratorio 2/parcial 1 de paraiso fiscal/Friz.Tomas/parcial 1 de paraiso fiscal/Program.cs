using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_de_paraiso_fiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tomás Friz - OffShore";

            // Instancio los Clientes
            Cliente mauri = new Cliente(eTipoCliente.PoliticoCorrupto, "Mauri");
            Cliente fariña = new Cliente(eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCliente.JugadorDeFutbol, "Lio");

            // Instancio las CuentasOffShore
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro", eTipoCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678, 50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);

            // Instancio el ParaisoFiscal
            ParaisoFiscal panamaPappers = eParaisosFiscales.Panamá;

            // Agrego, quito y muestro las cuentas
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;

            panamaPappers.MostrarParaiso();

            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;

            panamaPappers.MostrarParaiso();

            Console.ReadKey();
        }
    }
}
