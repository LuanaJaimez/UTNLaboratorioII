using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entindades;
using System.Threading;
using Archivos;

namespace Clifton.Manuel._2D.Parcial2
{

    public partial class FrmSecundario : Form
    {
       
        public FrmSecundario()
        {
            InitializeComponent();
          
        }

        public void Cargar(string texto)
        {
            if (listEvaluados.InvokeRequired)
            {
                listEvaluados.BeginInvoke((MethodInvoker)delegate ()
                {
                this.listEvaluados.Items.Add(texto);
                   
                });
            }
            else
            {
                this.listEvaluados.Items.Add(texto);
            }
        }

        private void FrmSecundario_Load(object sender, EventArgs e)
        {

        }

    }//
}//
