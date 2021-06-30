using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Menor : Comensal
    {
        public enum eMenu
        {
            Milanesa,
            Hamburguesa
        }
        private eMenu _menu;

        #region Propiedad
        public eMenu Menu
        {
            get
            {
                return this._menu;
            }
            set
            {
                this._menu=value;
            }
        }
        #endregion

        #region Constructores
        private Menor(string nombre, string apellido):base(nombre,apellido)
        {

        }
        public Menor(string nombre,string apellido,eMenu menu):this(nombre,apellido)
        {
            this._menu = menu;
        }
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            return String.Format("{0}  {1} , Menor", base.Mostrar(), this.Menu);
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Menor a, Menor b)
        {
            bool retorno = false;
            
            
                if((a.Nombre==b.Nombre) && (a.Apellido==b.Apellido) && (a.Menu==b.Menu))
                {
                    retorno = true;
                }
            
            
            return retorno;
        }
        public static bool operator !=(Menor a, Menor b)
        {
            return !(a == b);
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Menor)
            {
                if ((Menor)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
