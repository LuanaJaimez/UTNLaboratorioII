using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Comensal
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        #endregion

        #region Propiedades
        public string Nombre { get {return this._nombre; }  }
        public string Apellido { get {return this._apellido; } }
        #endregion

        #region Constructor
        public Comensal (string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region Metodo
        public virtual string Mostrar()
        {
            return String.Format("{0} {1}", this.Nombre, this.Apellido);
        }
        #endregion
    }
}
