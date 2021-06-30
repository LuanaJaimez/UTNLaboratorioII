using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        #region Atributos
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;
        #endregion

        #region Constructores
        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            _listadoCuentas = new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisosFiscales lugar)
            :this()
        {
            this._lugar = lugar;
        }
        #endregion

        #region Métodos
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\nInicio de actividades: {ParaisoFiscal.fechaInicioActividades}\n");
            sb.AppendFormat($"Lugar de radicacion: {this._lugar}\n");
            sb.AppendFormat($"Cantidad de cuentas: {ParaisoFiscal.cantidadDeCuentas}\n");
            sb.AppendLine("********** Listado de cuentas offshore **********\n");
            foreach (CuentaOffShore item in this._listadoCuentas)
            {
                sb.AppendFormat($"{Cliente.RetornarDatos(item.Dueño)}");
                sb.AppendFormat($"Numero: {(int)item}\n");
                sb.AppendFormat($"Saldo: {item.Saldo}\n\n");
            }

            Console.WriteLine(sb.ToString());
        }
        #endregion

        #region Sobrecargas
        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }
        public static bool operator == (ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;
            foreach (CuentaOffShore item in pf._listadoCuentas)
            {
                if (item == cos)
                    retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator + (ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (!(pf == cos))
            {
                pf._listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se agrego la cuenta al paraíso...");
            }
            else
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    item.Saldo += cos.Saldo;
                    Console.WriteLine("La cuenta ya se encontraba en el paraíso...\n");
                }
            }
            return pf;
        }
        public static ParaisoFiscal operator - (ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf == cos)
            {
                ParaisoFiscal.cantidadDeCuentas--;
                pf._listadoCuentas.Remove(cos);
                Console.WriteLine("Se elimino la cuenta del paraíso...\n");
           }
            return pf;
        }
        #endregion
    }
}
