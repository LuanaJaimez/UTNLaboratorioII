using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        #region Constructor
        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio, titulo, nombre, apellido)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodo
        public string Mostrar()
        {
            
            return String.Format("{0}\nTipo: {1}", (string)this, this.tipo);
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator==(Manual a, Manual b)
        {
            bool retorno=false;
            if(((Libro)a) == ((Libro)b) && a.tipo==b.tipo)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static implicit operator double(Manual m)
        {
            return (double)m._precio;
        }
        #endregion

    }
}
