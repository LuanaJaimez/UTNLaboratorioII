using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;
        

        #region Propiedades
        public List<Prestamo> ListaDePrestamos { get { return this.listaDePrestamos; } }
        public string RazonSocial { get {return this.razonSocial; }  }
        public float InteresesEnDolares { get {return this.CalcularInteresGanado(TipoDePrestamo.Dolares); } }
        public float InteresesEnPesos { get {return this.CalcularInteresGanado(TipoDePrestamo.Pesos); } }
        public float InteresesTotales { get {return this.CalcularInteresGanado(TipoDePrestamo.Todos); } }
        #endregion

        #region Constructores
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Financiera financera)
        {
            return (string)financera;
        }
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRazon Social: {0}", financiera.razonSocial);
            sb.AppendFormat("Intereses Totales: {0} - Intereses Pesos: {1} - Interese Dolares: {2} ",financiera.InteresesTotales,financiera.InteresesEnPesos,financiera.InteresesEnDolares);
            financiera.OrdenarPrestamos();
            foreach(Prestamo item in financiera.ListaDePrestamos)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();

        }
        private float CalcularInteresGanado( TipoDePrestamo tipoDePrestamo)
        {
            float interesPesos = 0;
            float interesDolar = 0;
            float interesGral = 0;
            float retorno = 0;

            foreach(Prestamo item in this.ListaDePrestamos)
            {
                if(item is PrestamoPesos)
                {
                    interesPesos += ((PrestamoPesos)item).Interes;
                    interesGral += ((PrestamoPesos)item).Interes;
                }
                else if(item is PrestamoDolar)
                {
                    interesDolar += ((PrestamoDolar)item).Interes;
                    interesGral += ((PrestamoDolar)item).Interes;
                }
            }
            switch(tipoDePrestamo)
            {
                case TipoDePrestamo.Pesos:
                    retorno = interesPesos;
                    break;
                case TipoDePrestamo.Dolares:
                    retorno = interesDolar;
                    break;
                case TipoDePrestamo.Todos:
                    retorno = interesGral;
                    break;
                default:
                    break;
            }
            return retorno;

        }
        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator ==(Financiera financiera,Prestamo prestamo)
        {
            bool retorno=false;
            foreach(Prestamo item in financiera.ListaDePrestamos)
            {
                if (item==prestamo)
                {
                    retorno = true;
                }
            }
            return retorno;

        }
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }
        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera!=prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
        #endregion

    }
}
