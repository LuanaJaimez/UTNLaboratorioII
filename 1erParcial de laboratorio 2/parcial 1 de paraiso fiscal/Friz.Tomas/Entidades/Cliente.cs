using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;
        #endregion

        #region Constructores
        public Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }
        public Cliente(eTipoCliente tipoCliente)
            : this()
        {
            this._tipoDeCliente = tipoCliente;
        }
        public Cliente(eTipoCliente tipoCliente, string nombre)
            : this(tipoCliente)
        {
            this._nombre = nombre;
        }
        #endregion

        #region Métodos
        private void CrearAlias()
        {
            Random rand = new Random();
            int numeroRandom = rand.Next(1000, 9999);

            this._aliasParaIncognito = numeroRandom + this._tipoDeCliente.ToString();
        }
        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }
            return this._aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre {this._nombre}\n");
            sb.AppendFormat($"Tipo de cliente: {this._tipoDeCliente}\n");
            sb.AppendFormat($"Alias: {this.GetAlias()}\n");
            return sb.ToString();
        }
        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }
        #endregion
    }
}
