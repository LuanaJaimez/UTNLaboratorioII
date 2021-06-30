using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Mayor : Comensal
    {
        public enum eBebidas
        {
            Agua,
            Vino,
            Cerveza,
            Gaseosa
        }
        private eBebidas _bebida;

        #region Propiedad
        public eBebidas Bebida { get {return this._bebida; }  }
        #endregion

        #region Constructor
        public Mayor(string nombre, string apellido, eBebidas bebida):base(nombre,apellido)
        {
            this._bebida = bebida;
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator ==(Mayor a, Mayor b)
        {
            bool retorno = false;
            
                if((a.Nombre==b.Nombre) && (a.Apellido==b.Apellido))
                {
                    retorno = true;
                }
            return retorno;
        }
        public static bool operator !=(Mayor a, Mayor b)
        {
            return !(a == b);
        }
        public static explicit operator string(Mayor a)
        {
            return a.Mostrar() + " " + a.Bebida;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return (string)this;
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Mayor)
            {
                if((Mayor)obj==this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
