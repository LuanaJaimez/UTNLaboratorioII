using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
            set
            { 
                if(value is List<Alumno>)
                {
                    this._alumnos = value;
                }
            }
        }
        public EMateria Nombre { get {return this._nombre; } set {this._nombre=value; } }
        #endregion

        #region Constructores
        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }
        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }
        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Materia: {0}\n", this._nombre);
            sb.AppendLine("*************************************");
            sb.AppendLine("**************ALUMNOS****************");
            foreach(Alumno item in this._alumnos)
            {
                sb.AppendLine(Alumno.Mostrar(item));
            }
            return sb.ToString(); 
        }
        public void CalificarAlumnos()
        {
            foreach(Alumno item in this._alumnos)
            {
                item.Nota = Materia._notaParaUnAlumno.Next(1, 10);
            }
        }

        #endregion

        #region Sobrecargas
        public static implicit operator Materia(EMateria nombre)
        {
            Materia miMateria = new Materia(nombre);
            return miMateria;
        }
        public static implicit operator float(Materia m)
        {
            float promedio;
            float sumadorNota=0;
            foreach(Alumno item in m.Alumnos)
            {
                sumadorNota += item.Nota;
            }
            promedio = sumadorNota / m.Alumnos.Count;
            return promedio;
        }
        public static explicit operator string(Materia materia)
        {
            //float promedio = materia;
            return String.Format("{0}", materia.Mostrar());
        }
        public static bool operator ==(Materia m,Alumno a)
        {
            bool retorno = false;
            foreach(Alumno item in m.Alumnos)
            {
                if(item==a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }
        public static Materia operator +(Materia m,Alumno a)
        {
            if(m!=a)
            {
                m.Alumnos.Add(a);
                Console.WriteLine("Se agrego el alumno en la materia {0}!!!!!", m.Nombre);
            }
            else
            {
                Console.WriteLine("El Alumno ya esta en la materia {0}!!!!!", m.Nombre);
            }
            return m;
        }
        public static Materia operator -(Materia m,Alumno a)
        {
            if(m==a)
            {
                m.Alumnos.Remove(a);
                Console.WriteLine("Se Quito en la materia {0} !!!!", m.Nombre);
            }
            else
            {
                Console.WriteLine("El alumno no esta en la materia {0}!!!!!", m.Nombre);
            }
            return m;
        }
        #endregion
    }
}
