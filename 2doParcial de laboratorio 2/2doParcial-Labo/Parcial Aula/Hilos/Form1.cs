using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hilos
{
    public partial class Form1 : Form
    {
        Thread t;
        Thread m;
        SqlConnection connection;
        SqlCommand command;
        List<string> listaMesnajes;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection();
          
            connection.ConnectionString = @"Data Source = DESKTOP-PGQ4HMM; Initial Catalog=Hilos; Integrated Security=True;";
            t = new Thread(new ParameterizedThreadStart(MostrarTiempo));
             m = new Thread(new ParameterizedThreadStart(MostrarMensaje));
            listaMesnajes = new List<string>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Mensajes";
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    listaMesnajes.Add(dr[1].ToString());
                }
                m.Start(this.statusStrip1);
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

        public void MostrarMensaje(object objeto)
        {
            StatusStrip msj = (StatusStrip)objeto;

            while (true)
            {
                if (msj.InvokeRequired)
                {
                    msj.BeginInvoke((MethodInvoker)delegate ()
                    {
                        msj.Text = listaMesnajes[mensajeRandom().Next(0,4)];
                    });
                }
                Thread.Sleep(3000);
            }
        }

       // TERMINAR QUE ES LO QUE MUESTRA MOSTRAR MENSAJE
        public Random mensajeRandom()
        {
            Random random = new Random();
            return random;
        }

        public void MostrarTiempo(object utcObjeto)
        {
            int utc = -3;
            Label lblModificar = (Label)utcObjeto;

            while (true)
            {
                if (lblModificar.InvokeRequired)
                {
                    lblModificar.BeginInvoke((MethodInvoker)delegate() {
                        lblModificar.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:MM:ss");
                    });
                }

                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start(this.Lb_tiempo);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
            if (m.IsAlive)
            {
                m.Abort();
            }
        }
    }
}
