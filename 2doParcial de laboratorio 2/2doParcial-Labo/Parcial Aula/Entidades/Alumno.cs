using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColor
    {
        SinSala,Naranja,Rojo,Amarillo,Verde
    }

    public class Alumno : Persona
    {
        private EColor colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        public Alumno()
        {

        }

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota) : base(nombre, apellido, dni, femenino)
        {
            this.precioCuota = precioCuota;
        }

        public EColor ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }


        public static implicit operator Responsable(Alumno al)
        {
            return  al.responsable;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (!(a1 is null))
            {
                return (a1.legajo == a2.legajo && (Responsable)a1 == (Responsable)a2);
            }
            return false;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static bool operator +(List<Alumno> alumnos, Alumno alumno)
        {
            if (!(alumno is null))
            {
                if ( !(alumnos.Contains(alumno)))
                {
                    alumnos.Add(alumno);
                    return true;
                }
            }

            return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Cuota: {this.precioCuota}");
            sb.AppendLine($"Sala: {this.colorSala}");
            if (!(this.responsable is null))
            {
                sb.AppendLine($"Responsable: {this.responsable.ToString()}");
            }
            

            return sb.ToString();
        }







    }//
}//
