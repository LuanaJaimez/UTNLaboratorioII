using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entindades
{
    [Serializable]
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string direccion;

        public Persona()
        {

        }


        protected Persona(string nombre, string apellido, int dni, int edad, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Edad = edad;
            this.Direccion = direccion;

        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }

        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                ValidarPersonaSinApellido(value);
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                ValidarPersonaSinNombre(value);
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                ValidarPersonaSinDni(value);
                this.dni = value;
            }
        }


        public void ValidarPersonaSinDni(int value)
        {
            if (value < 1000000)
            {
                throw new PersonaInvalidaException("DNI Invalido");
            }
        }

        public void ValidarPersonaSinNombre(string value)
        {
            if (Validaciones.ValidarString(value) == false)
            {
                throw new PersonaInvalidaException("Nombre Invalido");
            }
        }

        public void ValidarPersonaSinApellido(string value)
        {
            if (Validaciones.ValidarString(value) == false)
            {
                throw new PersonaInvalidaException("Apellido Invalido");
            }
        }






    }//
}//
