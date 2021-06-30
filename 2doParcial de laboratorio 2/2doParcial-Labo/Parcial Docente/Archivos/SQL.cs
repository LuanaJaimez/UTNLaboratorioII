using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;
using Entindades;

namespace Archivos
{
    public static class SQL
    {
        public static bool Conectar(SqlConnection connection)
        {
            int contador = 0;  
            try
            {
                SqlCommand command = new SqlCommand();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    command.Connection = connection;
                    contador++;
                }
            }
            catch (Exception ex)
            {
                //Completar logs
                throw new ArchivoException(ex.Message, ex);
            }
            finally
            {
               // completar con logs
            }
            if (contador > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static SqlDataReader dr;
        public static SqlDataReader Leer(SqlConnection connection, string query)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.Connection = connection;
                command.CommandText = query;

                 dr = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                throw new ArchivoException(ex.Message, ex);
            }
            finally
            {

            }
            return dr;
        }


        public static int Guardar(SqlConnection connection, List<SqlParameter> listParameters, string query)
        {
            int retorno = -1;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = query;

                foreach (SqlParameter item in listParameters)
                {
                    command.Parameters.Add(item);
                }

                retorno = command.ExecuteNonQuery();

                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

            //esto nova
           
        }


    }//
}//
