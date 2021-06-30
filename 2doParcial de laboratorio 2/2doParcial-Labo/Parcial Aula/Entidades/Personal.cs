using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ETurno
    {
        Mañana, Tarde
    }

    public enum ECargo
    {
        Portería = 100, Cocina = 110, Sexretaría = 140, Tesorería = 240, Dirección = 180
    }
    [XmlInclude(typeof(Docente))]
    [XmlInclude(typeof(Administrativo))]
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        public Personal()
        {

        }

        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime hrEntrada, DateTime hrSalida) : base(nombre, apellido, dni, femenino)
        {
            this.horaEntrada = hrEntrada;
            this.horaSalida = hrSalida;
        }

        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get { return this.CalcularSalario(); }
        }

        protected abstract double CalcularSalario();



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hora Entrada: {this.horaEntrada}");
            sb.AppendLine($"Hora Salida: {this.horaSalida}");

            return sb.ToString();
        }


    }//
}//
