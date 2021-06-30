using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion

        #region Propiedades
        public string Nombre {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region Constructores
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Metodos
        protected virtual string DatosCompletos()
        {
            return this.nombre + " - " + this.raza;
        }
        protected abstract string Ficha();
        #endregion

        #region Sobrecargas
        public static bool operator == (Mascota m1, Mascota m2)
        {
            return (m1.nombre == m2.nombre && m1.raza == m2.raza);
        }
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
