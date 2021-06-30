using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributos
        protected float cilindrada;
        #endregion

        #region Constructor
        public Moto(string patente, byte cantRuedas, EMarcas marca, float cilindrada)
                : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Metodos
        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.Mostrar()}");
            sb.AppendFormat($"Tara: {this.cilindrada}\n\n");

            return sb.ToString();
        }
        #endregion
    }
}
