using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        #region Atributos
        public bool deMetal;
        #endregion

        #region Propiedades
        public override bool PreciosCuidados 
        { 
            get 
            { 
                return false; 
            } 
        }
        #endregion

        #region Constructores
        public Sacapunta(bool metal, double precio, string marca) : base(marca, precio)
        {
            this.deMetal = metal;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.UtilesToString());
            cadena.AppendFormat("De Metal: {0}\nPrecio Cuidado: {1}", this.deMetal, this.PreciosCuidados);

            return cadena.ToString();
        }
        #endregion
    }
}
