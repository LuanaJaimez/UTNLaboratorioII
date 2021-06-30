using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Docente : Personal //, IMensaje<Docente>
    {
        private double valorHora;

		public Docente()
		{

		}

		public Docente(string nombre, string apellido, int dni, bool femenino, DateTime hrEntrada, DateTime hrSalida, double valorHora) : base(nombre, apellido, dni, femenino, hrEntrada, hrSalida)
		{
			this.valorHora = valorHora;
		}

		public double ValorHora
		{
			get { return this.valorHora; }
			set { this.valorHora = value; }
		}

		public double HorasMensuales
		{
			get { return (((this.HoraSalida.Hour + this.HoraSalida.Minute) - this.HoraEntrada.Hour + this.HoraEntrada.Minute) * 20); }
		}
		public double HoraDiaria
		{
			get
			{
				double horasDiarias;
				horasDiarias = HoraSalida.Subtract(HoraEntrada).TotalHours + HoraSalida.Subtract(HoraEntrada).TotalMinutes;
				return (double)horasDiarias;
			}

		}

		public string Entrada
		{
			get { return this.HoraEntrada.ToString("HH:mm"); }
		}


		public string Salida
		{
			get { return this.HoraSalida.ToString("HH:mm"); }
		}

		

		protected override double CalcularSalario()
		{
			return this.valorHora* this.HorasMensuales;
		}





		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.ToString());
			sb.AppendLine($"Valor Hora: {this.valorHora}");


			return sb.ToString();
		}


		// INTERFACE
		//public Docente AutoReferencia {
		//	get { return this; }
		//	set { this.Dni = value.Dni;  } 
		//}

		//public string MostrarMsj()
		//{
		//	return this.ToString();
		//}






	}//
}//
