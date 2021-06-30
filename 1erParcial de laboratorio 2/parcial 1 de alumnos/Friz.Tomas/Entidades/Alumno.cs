using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        #region Propiedades
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Legajo { get { return this._legajo; } set { this._legajo = value; } }
        public string Nombre { get{return this._nombre;} set {this._nombre=value; } }
        public float Nota { get {return this._nota; } set {this._nota=value; } }
        #endregion

        #region Constructores
        public Alumno()
        {
            this._apellido = "";
            this._legajo = 0;
            this._nombre = "";
            this._nota = 0;
        }
        public Alumno(int legajo):this()
        {
            this._legajo = legajo;
        }
        public Alumno (int legajo,string nombre):this(legajo)
        {
            this._nombre = nombre;
        }
        public Alumno (int legajo,string nombre,string apellido):this(legajo,nombre)
        {
            this._apellido = apellido;
        }

        #endregion

        #region Metodos
        private string Mostrar()
        {
            return String.Format( "{0}, {1} - Legajo: {2} - Nota: {3} ",this._apellido,this._nombre,this._legajo,this._nota);
        }
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }
        public static bool operator ==(Alumno a1,Alumno a2)
        {
            bool retorno = false;
            if(a1.Legajo==a2.Legajo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
