using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        #region Atributos
        public bool soloLapiz;
        #endregion

        #region Propiedades
        public override bool PreciosCuidados 
        { 
            get 
            { 
                return true; 
            } 
        }
        #endregion

        #region Constructores
        public Goma(bool lapiz, string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = lapiz;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.UtilesToString());
            cadena.AppendFormat("SoloLapiz: {0}\nPrecio Cuidado: {1}", this.soloLapiz, this.PreciosCuidados);

            return cadena.ToString();
        }
        #endregion
    }
}
