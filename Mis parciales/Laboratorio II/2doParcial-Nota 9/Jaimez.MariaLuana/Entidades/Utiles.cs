using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Utiles
    {
        #region Atributos
        public string marca;
        public double precio;
        #endregion

        #region Propiedades
        public abstract bool PreciosCuidados 
        { 
            get; 
        }
        #endregion

        #region Constructores
        public Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public Utiles() 
        { 
        
        }
        #endregion

        #region Metodos
        protected virtual string UtilesToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("Marca: {0}\nPrecio: {1}", this.marca, this.precio);

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.UtilesToString();

        }
        #endregion
    }
}
