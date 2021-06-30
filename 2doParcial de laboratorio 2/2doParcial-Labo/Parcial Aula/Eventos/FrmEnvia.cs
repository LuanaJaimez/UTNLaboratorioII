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

    public delegate void CargarMensaje(string palabra);

    public partial class FrmEnvia : Form
    {
        public FrmEnvia()
        {
            InitializeComponent();
        }

        public event CargarMensaje EnviarMensaje;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text != string.Empty)
            {
                if (!(EnviarMensaje.GetInvocationList() is null ))
                {
                    EnviarMensaje.Invoke(txtTexto.Text);
                }
               
            }
        }
    }
}
