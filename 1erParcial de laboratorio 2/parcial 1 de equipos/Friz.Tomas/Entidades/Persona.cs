using System;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public string Nombre { get {return this.nombre; } }
        public string Apellido { get {return this.apellido; } }
        #endregion

        #region Constructor
        public Persona (string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Metodos
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return String.Format("{0} {1}", this.nombre, this.apellido);

        }
        #endregion
                          
    }
}
