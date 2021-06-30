
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_version_2_de_mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo miGrupo = new Grupo("Ortales", TipoManada.Mixta);
            Mascota mascota1 = new Perro("Abel", "Pitbull", 4, true);
            Mascota mascota2 = new Gato("Nala", "Gatuno");
            Mascota mascota3 = new Perro("Juan", "Bull Terrier", 2, false);
            Mascota mascota4 = new Gato("Perla", "Gris Tigre");

            miGrupo += mascota1;
            miGrupo += mascota2;
            miGrupo += mascota3;
            miGrupo += mascota4;

            string lista = miGrupo;

            Console.WriteLine(lista);

            miGrupo -= mascota1;

            string lista2=miGrupo;

            Console.WriteLine(lista2);


            Console.ReadKey();
        }
    }
}
