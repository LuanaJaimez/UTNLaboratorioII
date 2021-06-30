using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        #region Propiedad
        public int CantidadDePaginas
        {
            get
            {
                if(this._cantidadDePaginas==0)
                {

                    this._cantidadDePaginas= Libro._generadorDePaginas.Next(10, 580);
                    
                }
                return this._cantidadDePaginas;
                
            }
            
        }
        #endregion

        #region Constructores;
        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }
        public Libro(string titulo,Autor autor, float precio)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = autor;
            this._cantidadDePaginas = CantidadDePaginas;

        }
        public Libro(float precio, string titulo, string nombre, string apellido) : this(titulo, new Autor(nombre, apellido), precio)
        {



        }
        #endregion

        #region Metodo
        private static string Mostrar(Libro l)
        {
            string autor = l._autor;
            return String.Format("LIBRO: {0}\nCANTIDAD DE PAGINAS: {1}\nAUTOR: {2}\nPRECIO: {3}",l._titulo,l.CantidadDePaginas,autor,l._precio);
        }

        #endregion

        #region Sobrecargas
        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;
            
            
                if (a._titulo == b._titulo && a._autor == b._autor)
                {
                    retorno = true;
                }
            
            else if (Object.Equals(a, null) && Object.Equals(b, null))
            {
                retorno = true;

            }
            return retorno;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
        #endregion



    }
}
