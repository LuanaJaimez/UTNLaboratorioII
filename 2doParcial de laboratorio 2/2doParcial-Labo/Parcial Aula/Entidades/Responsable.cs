using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum EParentesco
    {
        Madre,Padre,Tia,Tio,Abuela,Abuelo,Otro
    }


    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;

        public Responsable()
        {

        }

        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }


        public static bool operator ==(Responsable r1, Responsable r2)
        {
            if (!(r1 is null))
            {
                return (r1.Dni == r2.dni);
            }
            return false;
        }
        public static bool operator !=(Responsable r1, Responsable r2)
        {
            return !(r1 == r2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Parentesco: {this.parentesco}");
            sb.AppendLine($"Telefono: {this.telefono}");

            return sb.ToString();
        }














    }//
}//
