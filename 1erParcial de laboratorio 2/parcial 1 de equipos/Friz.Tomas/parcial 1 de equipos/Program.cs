using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_de_equipos
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico miDt = new DirectorTecnico("Carlos", "Bianchi");
            Jugador j1 = new Jugador("Juan Roman", "Riquelme",10,false);
            Jugador j2 = new Jugador("Martin", "Palermo",9,false);
            Jugador j3 = new Jugador("Marcelo", "Delgado",16,false);
            Jugador j4 = new Jugador("Jorge", "Bermudez",2,true);
           
            Equipo miEquipo = new Equipo("Boca", miDt, Deportes.Futbol);

            miEquipo += j1;
            miEquipo += j2;
            miEquipo += j3;
            miEquipo += j4;

            string Lista = miEquipo;

            Console.WriteLine(Lista);

            miEquipo -= j2;
            string lista2 = miEquipo;

            Console.WriteLine(lista2);



            Console.ReadKey();

        }
    }
}
