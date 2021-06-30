using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class ConectarBD
    {
        //Cadena de Conexion
        string stringCadena = @"Data Source = FRANCISCO\SQLEXPRESS ; Initial Catalog = JardinUtn;Integrated Security=True";

        public SqlConnection Conectarbd = new SqlConnection();
  
        //Constructor
        public ConectarBD()
        {
            Conectarbd.ConnectionString = stringCadena;
            //sm.Connection = Conectarbd;
        }
        

        //Metodo para abrir la conexion
        public string Conectar(string cadena)
        {
            this.stringCadena = cadena;
            return cadena;
        }
        //public SqlCommand RetornaCommand()
        //{
        //    sm.Connection = Conectarbd;
        //    return sm;
        //}

        //Metodo para cerrar la conexion
        public void CerrarBD()
        {
            Conectarbd.Close();
        }
    }
    
}
