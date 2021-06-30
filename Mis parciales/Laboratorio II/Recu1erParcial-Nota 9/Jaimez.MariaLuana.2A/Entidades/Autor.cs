using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Constructores
        public Autor(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;

            if (a.nombre == b.nombre && a.apellido == b.apellido)
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
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("AUTOR: {0} - {1}\n", a.nombre, a.apellido);

            return retorno.ToString();
        }
        #endregion
    }
}
