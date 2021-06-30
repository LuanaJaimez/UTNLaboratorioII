using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        #region Atributos
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas;
        protected float precio;
        protected string titulo;
        #endregion

        #region Propiedades
        public int CantidadDePaginas
        {
            get
            {
                if (cantidadDePaginas == 0)
                {
                    this.cantidadDePaginas = generadorDePaginas.Next(10, 570);
                }

                return this.cantidadDePaginas;
            }
        }
        #endregion

        #region Constructores
        static Libro()
        {
            Libro.generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
            this.cantidadDePaginas = CantidadDePaginas;
        }

        public Libro(string titulo, string nombre, string apellido, float precio) 
            : this(precio, titulo, new Autor(nombre, apellido))
        {

        }
        #endregion

        #region Metodos
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat((string)l.autor);
            sb.AppendFormat("TITULO: {0}\n", l.titulo);
            sb.AppendFormat("CANTIDAD DE PAGINAS: {0}\n", l.CantidadDePaginas);
            sb.AppendFormat("PRECIO: {0}\n", l.precio);

            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Libro a, Libro b)
        {
            return a.titulo == b.titulo && a.autor == b.autor;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        #endregion
    }
}
