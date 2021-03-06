using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        #region Atributos
        public ETipo tipo;
        #endregion

        #region Constructores
        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo)
            : base(precio, titulo, new Autor(nombre, apellido))
        {
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(((string)(this)));
            retorno.AppendFormat("TIPO: {0}\n", this.tipo.ToString());

            return retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Manual && (Manual)obj == this;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Manual a, Manual b)
        {
            return (Libro)a == (Libro)b && a.tipo == b.tipo;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }
        #endregion
    }
}
