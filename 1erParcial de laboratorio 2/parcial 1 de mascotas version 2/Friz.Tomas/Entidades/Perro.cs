using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Propiedades
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad=value;
            }
        }
        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa=value;
            }
        }
        #endregion

        #region Constructores
        public Perro (string nombre, string raza, int edad, bool esAlfa):this(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        public Perro(string nombre,string raza):base(nombre,raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            string retorno;
            if(this.EsAlfa==true)
            {
                retorno = this.DatosCompletos() + " Alfa de la manada, " + "edad" + this.Edad;
            }
            else
            {
                retorno = this.DatosCompletos() + " edad" + this.Edad;
            }
            return retorno;
        }
        #endregion

        #region SobreCargas
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                if((Perro)obj==this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        
        #endregion

        #region Sobrecargas Operadores
        public static bool operator ==(Perro j1,Perro j2)
        {
            bool retorno=false;
            
            
                if(j1.Nombre==j2.Nombre && j1.Raza==j2.Raza && j1.Edad==j2.Edad)
                {
                    retorno = true;
                }
            
            return retorno;
        }
        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        #endregion
    }
}
