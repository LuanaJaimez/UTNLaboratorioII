using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class FrmRecibe : Form
    {
        public FrmRecibe()
        {
            InitializeComponent();
        }

        public void MostrarMesnaje(string texto)
        {
            this.lbRecibe.Text = texto;
        }
              //  button1.Click -= button1_Click;
               // textBox1.Text = (int.Parse(btnTexto.Text) + 1).ToString();
               // button2.Click += button2_Click;
        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Click -= button1_Click;
            //MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //button2.Click += button2_Click;
            ManejadorEventos(sender);
           // button1.Click += ManejadorEventos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Click -= button2_Click;
            //MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //button3.Click += button3_Click;
            ManejadorEventos(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Click -= button3_Click;
            //MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //button4.Click += button4_Click;
            ManejadorEventos(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button4.Click -= button4_Click;
            //MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //button1.Click += button1_Click;
            ManejadorEventos(sender);
        }

        public void Mensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
        }

        private void ManejadorEventos(object sender)
        {
            switch (((Button)sender).Name)
            {
                case "button1_Click":
                    button1.Click -= Mensaje;
                    button2.Click += Mensaje;
                    break;
                case "button2_Click":
                    button2.Click -= Mensaje;
                    button3.Click += Mensaje;
                    break;
                case "button3_Click":
                    button3.Click -= Mensaje;
                    button4.Click += Mensaje;
                    break;
                case "button4_Click":
                    button4.Click -= Mensaje;
                    button1.Click += Mensaje;
                    break;

                default:
                    break;
                    
            }
        }


    }
}
