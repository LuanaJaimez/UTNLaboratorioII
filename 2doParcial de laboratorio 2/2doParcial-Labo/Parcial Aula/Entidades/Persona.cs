using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Personal))]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Responsable))]
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected bool femenino;
        protected string nombre;

        public Persona()
        {

        }


        protected Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

            this.Dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, bool femenino):this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }

        public string Apellido
        {
            get { return this.apellido; }
            set 
            {
                //ValidarPersonaSinApellido(value);
                this.apellido = value; 
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set 
            {
               // ValidarPersonaSinNombre(value);
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
             //   ValidarPersonaSinDni(value);
                this.dni = value; 
            }
        }

        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Dni: {this.dni}");
            if (this.femenino == true)
            {
                sb.AppendLine($"Sexo: Femenimo");
            }
            else
            {
                sb.AppendLine($"Sexo: Masculino");
            }

            return sb.ToString();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.nombre} {this.apellido}");
            return sb.ToString();
        }

      


    }//
}//
