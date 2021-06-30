using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Autor
    {
        private string nombre;
        private string apellido;

        #region Constructor
        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if(a.nombre==b.nombre && a.apellido==b.apellido)
                {
                   retorno = true;
                }
                
            }
            else if (Object.Equals(a, null) && Object.Equals(b, null))
            {
                retorno = true;
            }
            return retorno;

        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
        public static implicit operator string(Autor a)
        {
            return String.Format("AUTOR: {0} {1}", a.nombre, a.apellido);
        }
        #endregion
    }
}
