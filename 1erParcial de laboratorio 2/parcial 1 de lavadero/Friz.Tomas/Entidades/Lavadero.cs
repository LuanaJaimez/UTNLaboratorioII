using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        #endregion

        #region Constructores
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto)
            : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        #endregion

        #region Propiedades
        public string MiLavadero
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Lavadero\n");
                sb.AppendLine($"Precios Vigentes:");
                sb.AppendFormat($"Precio Auto: {this.precioAuto}\n");
                sb.AppendFormat($"Precio Camion: {this.precioCamion}\n");
                sb.AppendFormat($"Precio Moto: {this.precioMoto}\n");
                sb.AppendLine("\nListado de vehiculos: ");
                foreach (Vehiculo item in this.Vehiculos)
                {
                    if(item is Auto)
                    {
                        sb.AppendFormat($"{((Auto)item).MostrarAuto()}");
                    }
                    else if(item is Camion)
                    {
                        sb.AppendFormat($"{((Camion)item).MostrarCamion()}");
                    }
                    else if(item is Moto)
                    {
                        sb.AppendFormat($"{((Moto)item).MostrarMoto()}");
                    }
                }
                return sb.ToString();
            }
        }
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }
        #endregion

        #region Metodos
        public double MostrarTotalFacturado()
        {
            double facturacion = 0;
            foreach (Vehiculo item in this.Vehiculos)
            {
                if (item is Auto)
                    facturacion += this.precioAuto;
                else if (item is Camion)
                    facturacion += this.precioCamion;
                else if (item is Moto)
                    facturacion += this.precioMoto;
            }
            return facturacion;
        }
        public double MostrarTotalFacturado(EVehiculo vehiculo)
        {
            double facturacion = 0;
            foreach (Vehiculo item in this.Vehiculos)
            {
                if (item is Auto && vehiculo == EVehiculo.Auto)
                {
                    facturacion += this.precioAuto;
                }
                else if (item is Camion && vehiculo == EVehiculo.Camion)
                {
                    facturacion += this.precioCamion;
                }
                else if (item is Moto && vehiculo == EVehiculo.Moto)
                {
                    facturacion += this.precioMoto;
                }
            }
            return facturacion;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Patente, v2.Patente);
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Marca.ToString(), v2.Marca.ToString());
        }
        #endregion


        #region Sobrecargas de operadores
        public static bool operator == (Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach (Vehiculo item in lavadero.Vehiculos)
            {
                if (item == vehiculo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }
        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(!(lavadero == vehiculo))
                lavadero.Vehiculos.Add(vehiculo);
            return lavadero;
        }
        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
                lavadero.Vehiculos.Remove(vehiculo);
            return lavadero;
        }
        #endregion
    }
}
