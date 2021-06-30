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
    public partial class FrmPrincipal : Form
    {

        FrmRecibe recibe;


        public FrmPrincipal()
        {
            InitializeComponent();
            recibe = new FrmRecibe();
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            FrmEnvia envia = new FrmEnvia();
            envia.EnviarMensaje += recibe.MostrarMesnaje;
            envia.EnviarMensaje += MostrarMensajePrincipal;
            envia.Show();

            this.btnTexto.Click -= btnTexto_Click;
        }
        private void MostrarMensajePrincipal(string palabra)
        {
            MessageBox.Show(palabra);
        }

        private void btnRecibe_Click(object sender, EventArgs e)
        {
            recibe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;
            textBox1.Text = (int.Parse(btnTexto.Text) + 1).ToString();
            button2.Click += button2_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click -= button2_Click;
            textBox1.Text = (int.Parse(btnTexto.Text) + 1).ToString();
            button1.Click += button1_Click;
        }
    }
}
