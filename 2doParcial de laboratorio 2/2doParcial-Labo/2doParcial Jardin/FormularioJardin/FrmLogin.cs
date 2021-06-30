using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FormularioJardin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "1234")
            {
                MenPrincipal menu = new MenPrincipal();
                this.IsMdiContainer = true;
                menu.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Error vuelva a intentarlo");
            }
            

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //TimeSpan.FromMilliseconds(2000);
            //this.Close();
        }
    }
}
