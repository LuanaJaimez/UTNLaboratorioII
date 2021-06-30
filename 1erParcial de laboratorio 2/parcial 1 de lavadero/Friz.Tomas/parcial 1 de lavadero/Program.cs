using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace parcial_1_de_lavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo el lavadero con sus respectivos valores
            Lavadero lavadero = new Lavadero(200, 400, 50);

            // Creo 4 instancias de Auto, 2 iguales
            Auto a1 = new Auto("AAA", 4, EMarcas.Ford, 4);
            Auto a2 = new Auto("BBB", 4, EMarcas.Fiat, 4);
            Auto a3 = new Auto("AAA", 4, EMarcas.Ford, 4);
            Auto a4 = new Auto("JJJ", 4, EMarcas.Fiat, 4);
            Auto a5 = new Auto("ZZZ", 4, EMarcas.Honda, 4);

            // Creo 3 instancias de Camion
            Camion c1 = new Camion("HHH", 6, EMarcas.Iveco, 15000);
            Camion c2 = new Camion("III", 6, EMarcas.Scania, 20000);
            Camion c3 = new Camion("MMM", 8, EMarcas.Iveco, 25000);

            // Creo 3 instancias de Moto, 2 iguales
            Moto m1 = new Moto("PPP", 2, EMarcas.Zanella, 150);
            Moto m2 = new Moto("EEE", 2, EMarcas.Zanella, 250);
            Moto m3 = new Moto("III", 2, EMarcas.Zanella, 350);

            Console.WriteLine("Datos del lavadero\n");
            Console.WriteLine(lavadero.MiLavadero);

            // Agrego los autos al lavadero
            lavadero += a1;
            lavadero += a2;
            lavadero += a3;
            lavadero += a4;
            lavadero += a5;

            // Agrego los camiones al lavadero
            lavadero += c1;
            lavadero += c2;
            lavadero += c3;

            // Agrego las motos al lavadero
            lavadero += m1;
            lavadero += m2;
            lavadero += m3;

            Console.WriteLine(lavadero.MiLavadero);

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine($"Total Facturado: {lavadero.MostrarTotalFacturado()}\n");
            Console.WriteLine($"Total Facturado Autos: {lavadero.MostrarTotalFacturado(EVehiculo.Auto)}");
            Console.WriteLine($"Total Facturado Camiones: {lavadero.MostrarTotalFacturado(EVehiculo.Camion)}");
            Console.WriteLine($"Total Facturado Motos: {lavadero.MostrarTotalFacturado(EVehiculo.Moto)}\n");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vehiculos ordenados por patente:\n");
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lavadero.MiLavadero);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vehiculos ordenados por marca:\n");
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(lavadero.MiLavadero);

            Console.ReadKey();
        }
    }
}