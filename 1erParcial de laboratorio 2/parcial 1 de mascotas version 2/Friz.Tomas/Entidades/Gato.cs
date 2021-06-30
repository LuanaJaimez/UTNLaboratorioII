using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Constructor
        public Gato(string nombre,string raza):base(nombre,raza)
        {

        }
        #endregion

        #region Metodo
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Gato)
            {
                if((Gato)obj==this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Gato obj1,Gato obj2 )
        {
            bool retorno = false;
            
           
                if(obj1.Nombre==obj2.Nombre && obj1.Raza==obj2.Raza)
                {
                    retorno = true;
                }
            
            return retorno;
        }
        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion
    }
}
