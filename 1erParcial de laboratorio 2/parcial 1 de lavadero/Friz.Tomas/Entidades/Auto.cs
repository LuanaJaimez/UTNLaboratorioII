using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributos
        protected int cantidadAsientos;
        #endregion

        #region Constructor
        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos)
            :base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        #endregion

        #region Metodos
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.Mostrar()}");
            sb.AppendFormat($"Cantidad de asientos: {this.cantidadAsientos}\n\n");

            return sb.ToString();
        }
        #endregion
    }
}
