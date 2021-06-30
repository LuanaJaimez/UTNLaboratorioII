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
    public partial class FrmResponsables : Form
    {
        List<Responsable> listResponsables;

        public FrmResponsables()
        {
            InitializeComponent();
        }

        public FrmResponsables(List<Responsable> responsables) : this()
        {
            listResponsables = responsables;
            CargarTabla();
        }


        private void CargarTabla()
        {
            this.dataGridResponsable.Rows.Clear();
            int fila = 0;
            foreach (Responsable Aux in listResponsables)
            {
                fila = dataGridResponsable.Rows.Add();
                dataGridResponsable.Rows[fila].Cells[0].Value = Aux.Nombre;
                dataGridResponsable.Rows[fila].Cells[1].Value = Aux.Apellido;
                dataGridResponsable.Rows[fila].Cells[2].Value = Aux.Dni;
                if (Aux.Femenino)
                {
                    dataGridResponsable.Rows[fila].Cells[3].Value = "Mujer";
                }
                else
                {
                    dataGridResponsable.Rows[fila].Cells[3].Value = "Hombre";
                }
                dataGridResponsable.Rows[fila].Cells[4].Value = Aux.Parentesco;
                dataGridResponsable.Rows[fila].Cells[5].Value = Aux.Telefono;
            }
        }

        private void FrmResponsables_Load(object sender, EventArgs e)
        {
            dataGridResponsable.ReadOnly = true;
            dataGridResponsable.AllowUserToAddRows = false;
            dataGridResponsable.RowHeadersVisible = false;
        }
    }//
}//
