using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Propiedad
        public Deportes Deporte { set {Equipo.deporte=value; } }
        #endregion

        #region Constructores
        static Equipo ()
        {
            Equipo.deporte = Deportes.Futbol;
        }
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre,DirectorTecnico dt,Deportes deporte):this(nombre,dt)
        {
            this.Deporte = deporte;
        }
        #endregion

        #region Sobrecarga Operadoes
        public static bool operator ==(Equipo e, Jugador j )
        {
            bool retorno = false;
            foreach(Jugador item in e.jugadores)
            {
                if(item.Equals(j))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e,Jugador j)
        {
            if(e!=j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static Equipo operator -(Equipo e, Jugador j)
        {
            if(e==j)
            {
                e.jugadores.Remove(j);
            }
            return e;
        }
        
        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("**{0}**\n", e.nombre);
            sb.AppendLine("Nomina de Jugadores: ");
            foreach(Jugador item in e.jugadores)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendFormat("Dirigido por: {0}", e.dt.ToString());

            return sb.ToString();

        }
        #endregion
    }
}
