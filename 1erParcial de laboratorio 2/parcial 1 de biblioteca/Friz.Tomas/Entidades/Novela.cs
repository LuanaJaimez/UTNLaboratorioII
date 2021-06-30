using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Novela : Libro
    {
        public EGenero genero;
        #region Constructor
        public Novela(string titulo,float precio,Autor autor,EGenero genero):base(titulo,autor,precio)
        {
            this.genero = genero;
        }
        #endregion

        #region Metodo
        public string Mostrar()
        {
            
            return String.Format("{0}\nTipo: {1} ", (string)this, this.genero);
        }
        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;
            if(((Libro)a)==((Libro)b) && a.genero==b.genero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator double(Novela n)
        {
            return (double)n._precio;
        }
        #endregion
    }


}
