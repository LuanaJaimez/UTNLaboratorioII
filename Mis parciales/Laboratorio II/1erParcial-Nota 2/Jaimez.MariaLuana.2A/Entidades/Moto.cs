using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private ECilindrada cilindrada;

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(precio, modelo, null)
        {
            this.cilindrada = cilindrada;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #region Operadores
        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Moto a, Moto b)
        {
            return ((Vehiculo)a == (Vehiculo)b && a.cilindrada == b.cilindrada);
        }
        #endregion

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }



    }
}
