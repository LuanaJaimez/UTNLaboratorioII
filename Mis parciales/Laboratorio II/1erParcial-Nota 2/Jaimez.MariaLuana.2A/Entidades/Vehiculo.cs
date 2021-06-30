using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get
            { 
                if(this.velocidadMaxima == 0)
                {
                    generadorDeVelocidades = new Random();
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                }
                return this.velocidadMaxima;
           } 
        }

        #region Constructores
        static Vehiculo()
        {
            generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio)
            :this(precio, modelo, new Fabricante(marca, pais))
        {

        }
        #endregion

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Precio: {0}\r\n", v.precio);
            sb.AppendFormat("Modelo : {0}\r\n", v.modelo.ToString());
            sb.AppendFormat("Fabricante : {0}\r\n", v.fabricante.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #region "Operadores"
        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            return (a.modelo == b.modelo && a.fabricante == b.fabricante);
        }
        #endregion

        public static explicit operator string(Vehiculo v)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(string.Format($"*{v}"));
            mensaje.AppendLine(string.Format("Vehiculo:"));
            mensaje.AppendLine(string.Format($"{v.ToString()}"));
            
            return mensaje.ToString();
        }
    }
}
