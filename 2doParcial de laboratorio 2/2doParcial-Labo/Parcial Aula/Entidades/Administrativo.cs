using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        private ECargo cargo;
        static double SalarioBase;


        public Administrativo()
        {

        }
        static Administrativo()
        {
            SalarioBase = 30000;
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime hrEntrada, DateTime hrSalida, ECargo cargo) : base(nombre, apellido, dni, femenino, hrEntrada, hrSalida)
        {
            this.cargo = cargo;
        }


        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        public string Entrada
        {
            get { return this.HoraEntrada.ToString("HH:mm"); }
        }


        public string Salida
        {
            get { return this.HoraSalida.ToString("HH:mm"); }
        }

        //Redefine CalcularSalario multiplicando el salario base por el porcentaje de su cargo dividido 10
        protected override double CalcularSalario()
        {
            return ((SalarioBase * (double)this.cargo) / 100);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cargo : {this.cargo}");
            sb.AppendLine($"Salario : {this.CalcularSalario()}");

            return sb.ToString();
        }






    }//
}//
