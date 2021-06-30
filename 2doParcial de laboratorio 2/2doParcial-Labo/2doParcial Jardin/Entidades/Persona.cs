using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETurno
    {
        Mañana,
        Tarde
    }
    [Serializable]
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private bool femenino;

        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set 
            {
                //if(value < 1000000)
                //{
                //    throw new PersonaSinDNIException("Dni incorrecto");
                //}
                this.dni = value; 
            }
        }
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }
        #endregion

        #region Constructores

        public Persona()
        {

        }
         public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
        }
        public Persona(string nombre, string apellido, int dni, bool femenino):this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }
        
        #endregion

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Nombre: " + this.Nombre);
            st.AppendLine("Apellido: " + this.Apellido);
            st.AppendLine("Dni: " + this.Dni);
            st.AppendLine("Genero: " + this.Femenino);
            return st.ToString();


        }

    }
}
