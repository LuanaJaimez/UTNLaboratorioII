using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Prestamo
    {
        #region Atributos
        protected float monto;
        protected DateTime vencimiento;
        #endregion

           

        #region
        public float Monto { get {return this.monto; } }
        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(value>DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }
        #endregion

        #region Constructores
        public Prestamo(float monto,DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorFecha(Prestamo p1,Prestamo p2)
        {
            int retorno = -1;
            if(p1.Vencimiento>p2.Vencimiento)
            {
                retorno = 1;
            }
            else if (p1.Vencimiento == p2.Vencimiento)
            {
                retorno = 0;
            }
            return retorno;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return String.Format("Monto: {0} - Fecha de Vencimiento: ", this.Monto, this.Vencimiento);

        }
        #endregion
            
    }
}
