using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        #region Constructores
        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }
        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region Metodos
        public static string Mostrar (Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********************************************");
            sb.AppendLine("LISTADO DE LIBROS");
            sb.AppendLine("*********************************************");
            foreach(Libro item in e._libros)
            {
                if (item is Novela)
                {
                     sb.AppendLine(((Novela)item).Mostrar());
                     sb.AppendLine("\n");
                }
                else if( item is Manual)
                {
                    sb.AppendLine(((Manual)item).Mostrar());
                    sb.AppendLine("\n");
                }
                
                
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public static implicit operator Biblioteca (int capacidad)
        {
            Biblioteca miBiblioteca = new Biblioteca(capacidad);
            return miBiblioteca;
        }
        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;
            foreach(Libro item in e._libros)
            {
                if(item is Manual && l is Manual)
                {
                    if(((Manual)item)==((Manual)l))
                    {
                        retorno = true;
                    }

                }
                else if( item is Novela && l is Novela)
                {
                    if(((Novela)item) == ((Novela)l))
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }
        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if(e._libros.Count<e._capacidad )
            {
                if(e!=l)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("¡El libro ya esta en la biblioteca!\n");
                }
            }
            else
            {
                Console.WriteLine("! NO HAY MAS ESPACIO ¡\n");
            }
            return e;
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precio = 0;

            foreach (Libro item in this._libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        if (item is Manual)
                        {
                            precio += (Manual)item;
                        }
                        break;
                    case ELibro.Novela:
                        if (item is Novela)
                        {
                            precio += (Novela)item;
                        }
                        break;
                    case ELibro.Ambos:
                        if (item is Novela)
                        {
                            precio += (Novela)item;
                        }
                        else if (item is Manual)
                        {
                            precio += (Manual)item;
                        }
                        break;
                }
            }
            return precio;
        }
        #endregion

        #region Propiedades
        public double PrecioDeManuales { get {return this.ObtenerPrecio(ELibro.Manual); } }
        public double PrecioDeNovelas { get {return this.ObtenerPrecio(ELibro.Novela); } }
        public double PrecioTotal { get {return this.ObtenerPrecio(ELibro.Ambos); } }
        #endregion



    }
}
