using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;
        #endregion

        #region Propiedades
        public static ETipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        #endregion

        #region Constructores
        static Grupo()
        {
            Grupo.Tipo = ETipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, ETipoManada tipo)
            :this(nombre)
        {
            Grupo.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Grupo: {g.nombre} - Tipo: {Grupo.tipo.ToString()}\n");
            sb.AppendFormat($"Integrantes: ({g.manada.Count})\n");
            foreach (Mascota item in g.manada)
            {
                sb.AppendFormat($"{item.ToString()}\n");
                //if (item is Perro)
                //    sb.AppendFormat($"{((Perro)item).ToString()}\n");
                //else if (item is Gato)
                //    sb.AppendFormat($"{((Gato)item).ToString()}\n");
            }

            return sb.ToString();
        }
        public static bool operator == (Grupo g, Mascota m)
        {
            bool retorno = false;
            foreach (Mascota item in g.manada)
            {
                if (m.Equals(item))
                {
                    retorno = true;
                    break;
                }

                //if(item is Perro && ((Perro)item).Equals(m))
                //{
                //    retorno = true;
                //    break;
                //}
                //else if (item is Gato && ((Gato)item).Equals(m))
                //{
                //    retorno = true;
                //    break;
                //}
            }
            return retorno;
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
                g.manada.Add(m);
            else
            {
                Console.WriteLine($"Ya esta '{m.ToString()}' en el grupo");
                //if(m is Perro)
                //    Console.WriteLine($"Ya esta '{((Perro)m).ToString()}' en el grupo");
                //else if(m is Gato)
                //    Console.WriteLine($"Ya esta '{((Gato)m).ToString()}' en el grupo");
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
                g.manada.Remove(m);
            else
            {
                Console.WriteLine($"No esta '{m.ToString()}' en el grupo");
                //if (m is Perro)
                //    Console.WriteLine($"No esta '{((Perro)m).ToString()}' en el grupo");
                //else if (m is Gato)
                //    Console.WriteLine($"No esta '{((Gato)m).ToString()}' en el grupo");
            }
            return g;
        }
        #endregion
    }
}
