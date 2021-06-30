using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        #endregion

        #region Propiedad
        public TipoManada Tipo { set {Grupo.tipo=value; } }
        #endregion

        #region Constructores
        static Grupo()
        {
            Grupo.tipo= TipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, TipoManada tipo):this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator == ( Grupo e,Mascota j)
        {
            bool retorno = false;
            foreach(Mascota item in e.manada)
            {
                if(item.Equals(j))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static Grupo operator +(Grupo e,Mascota j)
        {
            if(e!=j)
            {
                e.manada.Add(j);
            }
            return e;
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            if(e==j)
            {
                e.manada.Remove(j);
            }
            return e;
        }
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("**{0}**\n", e.nombre);
            sb.AppendLine("Integrantes: ");
            foreach (Mascota  item in e.manada)
            {
                sb.AppendLine(item.ToString());
            }
            

            return sb.ToString();
        }
            

        #endregion

    }
}
