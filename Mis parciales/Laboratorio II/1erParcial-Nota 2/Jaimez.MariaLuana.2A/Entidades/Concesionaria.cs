using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        public enum EVehiculo { PrecioDeAutos, PrecioDeMotos, PrecioTotal }
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public double PrecioDeAutos
        {
            get
            {
                double precioTotalAutos = 0;

                foreach(Vehiculo item in this.vehiculos)
                {
                    if(item is Auto)
                    {
                        precioTotalAutos += (Double)(Auto)item;
                    }
                }
                return precioTotalAutos;
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                double precioTotalMotos = 0;

                foreach (Moto item in this.vehiculos)
                {
                    if (item is Moto)
                    {
                        precioTotalMotos += (Double)(Moto)item;
                    }
                }
                return precioTotalMotos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double total = 0;

                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Auto)
                    {
                        total += this.PrecioDeAutos;
                    }
                    else if(item is Moto)
                    {
                        total += this.PrecioDeMotos;
                    }
                }
                return total;
            }
        }

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: {0} \n", c.capacidad);
            foreach(Vehiculo item in c.vehiculos)
            {
                if(item is Auto)
                {
                    sb.AppendLine(((Auto)item).ToString());
                }
                else if(item is Moto)
                {
                    sb.AppendLine(((Moto)item).ToString());
                }
            }
            return sb.ToString();
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double retorno = 0;
            switch(tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    retorno = this.PrecioDeAutos;
                    break;
                case EVehiculo.PrecioDeMotos:
                    retorno = this.PrecioDeMotos;
                    break;
                default:
                    retorno = this.PrecioTotal;
                    break;
            }

            return retorno;
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if(c.capacidad < c.vehiculos.Count)
            {
                if(c!=v)
                {
                    c.vehiculos.Add(v);
                }
            }
            return c;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool retorno = false;

            if (c.vehiculos.Equals(v) == true)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
