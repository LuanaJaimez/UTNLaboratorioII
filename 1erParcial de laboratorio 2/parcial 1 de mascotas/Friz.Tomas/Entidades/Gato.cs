using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Constructores
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {

        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            return "Gato - " + base.DatosCompletos();
        }
        #endregion

        #region Sobrecargas
        public static bool operator == (Gato g1, Gato g2)
        {
            return (Mascota)g1 == (Mascota)g2;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is Gato)
            {
                rta = this == (Gato)obj;
            }
            return rta;
        }
        #endregion
    }
}
