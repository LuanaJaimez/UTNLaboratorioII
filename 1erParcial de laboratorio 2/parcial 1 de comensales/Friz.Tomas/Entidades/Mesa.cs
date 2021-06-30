using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Mesa
    {
        private List<Comensal> _comensales;
        private int _numero;
        public static int capacidad;

        #region Propiedades
        public int Cantidad { get {return this._comensales.Count; } }
        public List<Comensal> Comensales { get {return this._comensales; }  }
        public int Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                this.Numero=value;
            }
        }
        #endregion

        #region Constructores
        static Mesa()
        {
            Mesa.capacidad = 12;
        }
        private Mesa()
        {
            this._comensales = new List<Comensal>();
        }
        public Mesa(int numero):this()
        {
            this._numero = numero;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Mesa a, Mesa b)
        {
            bool retorno = false;
            
            
                if(a.Numero==b.Numero)
                {
                    retorno = true;
                }
            
            
           
            return retorno;
        }
        public static bool operator ==(Mesa a, Comensal b)
        {
            bool retorno = false;
            foreach(Comensal item in a.Comensales)
            {
                if(item.Equals(b))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Mesa a, Comensal b)
        {
            return !(a == b);
        }
        public static bool operator !=(Mesa a, Mesa b)
        {
            return !(a == b);
        }
        public static Mesa operator +(Mesa a, Comensal b)
        {
            if(a!=b && a.Cantidad<Mesa.capacidad)
            {
                a.Comensales.Add(b);
            }
            return a;
        }
        
        public static implicit operator string(Mesa a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mesa: "+ a.Numero+" Comensales: "+ a.Cantidad);
            foreach(Comensal item in a._comensales)
            {
                if(item is Mayor)
                {
                    sb.AppendLine(((Mayor)item).ToString());
                }
                else if ( item is Menor)
                {
                    sb.AppendLine(((Menor)item).ToString());
                }
            }
            return sb.ToString();
        }

        #endregion
    }
}
