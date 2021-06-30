using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        private ETipo tipo;

        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            :base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return (a.tipo == b.tipo && (Vehiculo)a == (Vehiculo)b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((string)(Vehiculo)this);
            sb.AppendFormat("TIPO: {0}", this.tipo);

            return sb.ToString();
        }
    }
}
