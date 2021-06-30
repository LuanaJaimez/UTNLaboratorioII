using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private bool esCapitan;
        private int numero;
        #endregion

        #region Constructores
        public Jugador(string nombre,string apellido):base(nombre,apellido)
        {
            this.esCapitan = false;
            this.numero = 0;
        }
        public Jugador(string nombre,string apellido,int numero,bool esCapitan):this(nombre,apellido)
        {
            this.esCapitan = esCapitan;
            this.numero = numero;

        }
        #endregion

        #region Porpiedades
        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan=value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero=value;
            }
        }
        #endregion

        #region Metodos
        protected override string FichaTecnica()
        {
            string fichaTecnica;
            if(this.esCapitan==true)
            {
                fichaTecnica = base.NombreCompleto() + ", Capitan del Equipo, " + " Camiseta Numero " + this.numero;
            }
            else
            {
                fichaTecnica = base.NombreCompleto() + ", Camiseta Numero " + this.numero;
            }
            return fichaTecnica;
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            bool retorno = false;
            
            
                if((j1.Nombre==j2.Nombre)&&(j1.Apellido==j2.Apellido)&&(j1.Numero==j2.Numero))
                {
                    retorno = true;
                }
            
            
            return retorno;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;

        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.FichaTecnica();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Jugador)
            {
                if((Jugador)obj==this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
