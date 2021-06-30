using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_de_comensales
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa miMesa = new Mesa(12);
            Comensal c1 = new Mayor("Juan", "Perez", Mayor.eBebidas.Cerveza);
            Comensal c2 = new Menor("Lucas", "Molina", Menor.eMenu.Hamburguesa);
            Comensal c3 = new Mayor("Miguel", "Silva", Mayor.eBebidas.Vino);
            Comensal c4 = new Menor("Catalina", "Silva", Menor.eMenu.Milanesa);

            miMesa += c1;
            miMesa += c2;
            miMesa += c3;
            miMesa += c4;

            string lista = miMesa;

            Console.WriteLine(lista);

            Console.ReadKey();


        }
    }
}
