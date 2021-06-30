using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PrestamoDolar: Prestamo
    {
        private PeriodicidadDePago periodicidad;

        #region Propiedades
        public PeriodicidadDePago Periodicidad { get {return this.periodicidad; } }
        public float Interes { get {return this.CalcularInteres(); } }
        #endregion

        #region Constructores
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public PrestamoDolar (Prestamo prestamo, PeriodicidadDePago periodicidad):this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {

        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float retorno = -1;
            if(this.Periodicidad==PeriodicidadDePago.Mensual)
            {
                retorno = 25;
            }
            else if (this.Periodicidad == PeriodicidadDePago.Bimestral)
            {
                retorno = 30;
            }
            else if (this.Periodicidad == PeriodicidadDePago.Trimestral)
            {
                retorno = 40;
            }
            return retorno;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.monto += dias * 25;
            this.Vencimiento = nuevoVencimiento;

        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2}", base.Mostrar(), this.periodicidad, this.Interes);
            return sb.ToString();
        }
        #endregion
    }
}
