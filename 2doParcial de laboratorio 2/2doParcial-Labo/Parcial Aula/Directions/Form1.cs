using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Direccion
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        List<KeyValuePair<decimal, string>> provincias;
        List<Localidad> localidades;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection();
            command = new SqlCommand();
            provincias = new List<KeyValuePair<decimal, string>>();
            localidades = new List<Localidad>();
            connection.ConnectionString = @"Data Source = DESKTOP-PGQ4HMM; Initial Catalog=Argentina; Integrated Security=True;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                
               
                command.Connection = connection;
                command.CommandText = "select * from Provincia";
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    provincias.Add(new KeyValuePair<decimal, string>(decimal.Parse(dr[0].ToString()), dr[1].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.cmbPrivincia.DataSource = provincias;
        }


        private void cmbPrivincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDirecciones();
            try
            {
                localidades.Clear();
                command.Parameters.Clear();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Localidad where idProvincia = @COSA"; //+ ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key;
                
                command.Parameters.Add(new SqlParameter("COSA", ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key));

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.cmbLocalidad.DataSource = null;
            this.cmbLocalidad.DataSource = localidades;
        }

        private void CargarDirecciones()
        {
            try
            {
                localidades.Clear();
                command.Parameters.Clear();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select calle,numero,piso,departamento,nombre as [Localidad] from Domicilio,localidad where Domicilio.idLocalidad = localidad.id";

                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            Directions direcciones = new Directions();

            direcciones.Calle = txtCalle.Text;
            direcciones.Numero = int.Parse(txtNumero.Text);
            direcciones.IdLocalidad = ((Localidad)cmbLocalidad.SelectedItem).Id;
            direcciones.Departamento = txtDepartamento.Text;
            direcciones.Piso = int.Parse(txtPiso.Text);

            try
            {
                localidades.Clear();
                command.Parameters.Clear();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into [domicilio] (calle, numero, piso, departamento, idLocalidad) values (@calle, @numero, @piso, @depatamento, @idLocalidad)";

                command.Parameters.Add(new SqlParameter("calle", direcciones.Calle));
                command.Parameters.Add(new SqlParameter("numero", direcciones.Numero));
                command.Parameters.Add(new SqlParameter("piso", direcciones.Piso));
                command.Parameters.Add(new SqlParameter("depatamento", direcciones.Departamento));
                command.Parameters.Add(new SqlParameter("idLocalidad", direcciones.IdLocalidad));

                // SqlDataReader dr = command.ExecuteReader();
                int retorno = command.ExecuteNonQuery();

                if (retorno != 1)
                {
                    MessageBox.Show("No se pudo insertar");
                }
                else
                {
                    // limpiar datos
                    MessageBox.Show("Se inserto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            CargarDirecciones();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // SEGUIR POR ACA!! DE PERROOOO
        }

        // SELECCIOINAR UN ITEM, CARGARLO EN LOS CAMPOS Y MODIFICARLO




    }//
}//
