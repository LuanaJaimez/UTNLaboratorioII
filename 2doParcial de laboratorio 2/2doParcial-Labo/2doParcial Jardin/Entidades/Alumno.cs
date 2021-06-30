using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores
    {
        //Naranja,
        //Rojo,
        //Amarillo,
        //Verde
        
        [Description("Naranja")]
        Naranja = 0,
        [Description("Rojo")]
        Rojo = 1,
        [Description("Amarillo")]
        Amarillo = 2,
        [Description("Verde")]
        Verde = 3
    }
    public enum EGrados
    {
        //Naranja,
        //Rojo,
        //Amarillo,
        //Verde

        [Description("Roja")]
        Roja = 1,
        [Description("Verde")]
        Verde = 2,
        [Description("Naranja")]
        Naranja = 3,
        [Description("Azul")]
        Azul = 4,
        [Description("Rosa")]
        Rosa = 5,
        [Description("Lila")]
        Lila = 6
    }
    public class Alumno : Persona
    {
        private int idAlumnos;
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private int edad;
        private string direccion;
        private int idAula;
        private string stringResponsable;
        private Responsable responsable;
        

        #region Propiedades
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }
        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public int IdAlumnos 
        {
            get { return this.idAlumnos; }
            set { this.idAlumnos = value; } 
        }

        #endregion

        #region Constructores
        public Alumno()
        {

        }
        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota, EColores colorAula):base(nombre, apellido, dni, femenino)
        {
            this.colorSala = colorAula;
        }
        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota):base(nombre,apellido,dni,femenino)
        {
            //this.responsable  = new Responsable(this.responsable.Nombre, this.responsable.Apellido, this.responsable.Dni, this.responsable.Femenino, this.responsable.Parentesco, this.responsable.Telefono);
            this.precioCuota = precioCuota;
            
            
        }
        public Alumno(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            //this.responsable  = new Responsable(this.responsable.Nombre, this.responsable.Apellido, this.responsable.Dni, this.responsable.Femenino, this.responsable.Parentesco, this.responsable.Telefono);
            


        }
        public Alumno(string nombre, string apellido, int dni, int eda, string direc, string resp, int IdAula, int idAlumnos) : base(nombre, apellido, dni)
        {
            this.edad = eda;
            this.direccion = direc;
            this.stringResponsable = resp;
            this.idAula = IdAula;
            this.idAlumnos = idAlumnos;
        }



        #endregion

        #region Operadores
        /// <summary>
        /// Va a retornar un responsable para el alumno que llega por parametro
        /// </summary>
        /// <param name="al"></param>
        public static implicit operator Responsable(Alumno al)
        {
            return al.Responsable;
        }
        /// <summary>
        /// Devuelve si un alumno es igual a otro,comparando Nombre,Apellido,Dni de ese Alumno
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return a1.Legajo == a2.Legajo;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        
        #endregion

        //Sobreescribo metodo toString y devuelve los datos de un alumno
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("----------------------------------------------");
            st.AppendLine("Datos del alumno");
            st.AppendLine("----------------------------------------------");
            st.AppendLine(base.ToString());
            st.AppendLine("Color de sala: "+ this.colorSala);
            st.AppendLine("Legajo: " + this.legajo);
            st.AppendLine("Precio de la Cuota: " + this.precioCuota);
            if(!object.Equals(this.responsable,null))
                st.AppendLine("Su responsable es: "+ this.Responsable.Nombre + this.Responsable.ToString());
            
            return st.ToString();

        }
    }
}
