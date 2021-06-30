using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PrestamoPesos :Prestamo
    {
        private float porcentajeInteres;

        public float Interes { get {return this.CalcularInteres(); } }

        #region Constructores
        public PrestamoPesos (float monto,DateTime vencimiento, float interes):base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }
        public PrestamoPesos(Prestamo prestamo,int porcentajeInteres):this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        {

        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float interes;
            interes = (this.monto * this.porcentajeInteres) / 100;
            return interes;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.porcentajeInteres += (int)0.25 * dias;
            this.Vencimiento = nuevoVencimiento; 
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2}", base.Mostrar(), this.porcentajeInteres, this.Interes);
            return sb.ToString();
        }
        #endregion
    }
}
