using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float tara;
        #endregion

        #region Constructor
        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
                : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        #endregion

        #region Metodos
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.Mostrar()}");
            sb.AppendFormat($"Tara: {this.tara}\n\n");

            return sb.ToString();
        }
        #endregion
    }
}
