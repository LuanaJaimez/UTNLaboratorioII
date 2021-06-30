using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal: Persona 
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        #region Propiedades
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

        //Debera calcular el salario teniendo en cuenta las hora que trabajo y el valor de la hora
        public double Salario
        {
            get { return 1; ; }
            
        }
        #endregion

        #region Constructores
        public Personal(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {

        }
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaentrada, DateTime horasalida) : base(nombre, apellido, dni, femenino)
        {
            this.horaEntrada = horaentrada;
            this.horaSalida = horasalida;
        }
        #endregion

        #region Metodos
        public abstract double CalcularSalario();
        

        #endregion




    }
}
