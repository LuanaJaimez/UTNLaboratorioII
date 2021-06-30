using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Clifton.Manuel
{
    public partial class FrmNoDocente : Form
    {
        List<Administrativo> listAdministrativos;

        public FrmNoDocente()
        {
            InitializeComponent();
        }


        public FrmNoDocente(List<Administrativo> adnministrativos) : this()
        {
            listAdministrativos = adnministrativos;
            CargarTabla();
        }

        private void CargarTabla()
        {
            this.dataGridNoDocente.Rows.Clear();
            int fila = 0;
            foreach (Administrativo Aux in listAdministrativos)
            {
                fila = dataGridNoDocente.Rows.Add();
                dataGridNoDocente.Rows[fila].Cells[0].Value = Aux.Nombre;
                dataGridNoDocente.Rows[fila].Cells[1].Value = Aux.Apellido;
                dataGridNoDocente.Rows[fila].Cells[2].Value = Aux.Dni;
                if (Aux.Femenino)
                {
                    dataGridNoDocente.Rows[fila].Cells[3].Value = "Mujer";
                }
                else
                {
                    dataGridNoDocente.Rows[fila].Cells[3].Value = "Hombre";
                }
                dataGridNoDocente.Rows[fila].Cells[4].Value = Aux.Entrada;
                dataGridNoDocente.Rows[fila].Cells[5].Value = Aux.Salida;
                dataGridNoDocente.Rows[fila].Cells[6].Value = Aux.Cargo;
            }
        }

        private void FrmNoDocente_Load(object sender, EventArgs e)
        {
            dataGridNoDocente.ReadOnly = true;
            dataGridNoDocente.AllowUserToAddRows = false;
            dataGridNoDocente.RowHeadersVisible = false;
        }
    }//
}//
