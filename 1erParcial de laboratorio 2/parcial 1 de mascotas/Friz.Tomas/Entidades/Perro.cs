using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro: Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Constructores
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        public Perro(string nombre, string raza)
            :this(nombre, raza, 0, false)
        {

        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            string cadena = null;
            if (this.esAlfa)
                cadena = "Perro - " + base.DatosCompletos() + ", alfa de la manada, edad " + (int)this;
            else
                cadena = "Perro - " + base.DatosCompletos() + ", edad " + (int)this;

            return cadena;
        }
        #endregion

        #region Sobrecargas de operadores
        public static bool operator == (Perro p1, Perro p2)
        {
            return (Mascota)p1 == (Mascota)p2 && (int)p1 == (int)p2;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator int(Perro p)
        {
            return p.edad;
        }
        #endregion

        #region Sobrecargas de metodos
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is Perro)
            {
                rta = this == (Perro)obj;
            }
            return rta;
        }
        #endregion
    }
}
