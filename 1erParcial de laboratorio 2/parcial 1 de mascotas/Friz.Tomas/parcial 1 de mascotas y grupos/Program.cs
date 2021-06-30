using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_de_mascotas_y_grupos
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perroUno = new Perro("Moro", "Pitbull");
            Perro perroDos = new Perro("Julio", "Cruza", 13, false);
            Perro perroTres = new Perro("Ramon", "Salchicha", 2, true);
            Perro perroCuatro = new Perro("Jose", "Angora", 2, false);
            Perro perroCinco = new Perro("Ramon", "Salchicha", 2, false);

            Gato gatoUno = new Gato("Jose", "Angora");
            Gato gatoDos = new Gato("Mauri", "Cruza");
            Gato gatoTres = new Gato("Fer", "Siames");
            Gato gatoCuatro = new Gato("Fer", "Siames");

            Console.WriteLine();

            Grupo grupoUno = new Grupo("Rio", ETipoManada.Mixta);

            grupoUno += perroUno;
            grupoUno += perroDos;
            grupoUno += perroTres;
            grupoUno += perroCuatro;

            // Repetidos
            grupoUno += perroCinco;
            grupoUno += perroUno;

            grupoUno += gatoUno;
            grupoUno += gatoDos;
            grupoUno += gatoTres;

            // Repetidos
            grupoUno += gatoCuatro;

            Console.WriteLine();

            // Cantidad 7 (4 perros - 3 gatos)
            Console.WriteLine(grupoUno);

            grupoUno -= perroUno;
            grupoUno -= perroTres;
            grupoUno -= gatoTres;

            // No estan
            grupoUno -= perroCinco;
            grupoUno -= gatoTres;
            grupoUno -= gatoCuatro;

            Console.WriteLine();

            // Cantidad 4 (2 perros / 2 gatos)
            Console.WriteLine(grupoUno);

            // Son distintos
            if (perroUno.Equals("perroUno"))
                Console.WriteLine("Son la misma mascota");
            else
                Console.WriteLine("No son la misma mascota");

            // Son iguales
            if (perroTres.Equals(perroCinco))
                Console.WriteLine("Son la misma mascota");
            else
                Console.WriteLine("No son la misma mascota");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
