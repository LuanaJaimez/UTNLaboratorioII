using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region Atributos
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;
        #endregion

        #region Propiedades
        public string Patente 
        {
            get
            {
                return this.patente;
            }
        }
        public EMarcas Marca
        {
            get
            {
                return this.marca;
            }
        }
        #endregion

        #region Constructores
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        #endregion

        #region Metodos
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Patente: {this.patente}\n");
            sb.AppendFormat($"Cantidad de ruedas: {this.cantRuedas}\n");
            sb.AppendFormat($"Marca: {this.marca}\n");

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas de operadores
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente && v1.Marca == v2.Marca);
        }
        public static bool operator != (Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
