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
    public partial class FrmAula : Form
    {
       // FrmAlumnosPorAula instAlumosXAula;

        FrmAltaAula instAula;


        List<Aula> listAulas;
        Aula unAula;

        public FrmAula()
        {
            InitializeComponent();
        }

        public FrmAula(List<Aula> aulas) : this()
        {
            listAulas = aulas;
            CargarTabla();
        }

        private void CargarTabla()
        {
            this.dataGridAula.Rows.Clear();
            int fila = 0;
            foreach (Aula Aux in listAulas)
            {
                fila = dataGridAula.Rows.Add();
                dataGridAula.Rows[fila].Cells[0].Value = Aux.ColorSala;
                dataGridAula.Rows[fila].Cells[1].Value = Aux.Turno;
                dataGridAula.Rows[fila].Cells[2].Value = $"{Aux.Docente.Nombre} {Aux.Docente.Apellido}";
            }
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            dataGridAula.ReadOnly = true;
            dataGridAula.AllowUserToAddRows = false;
            dataGridAula.RowHeadersVisible = false;
        }


        //private void dataGridAula_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    foreach (Aula item in listAulas)
        //    {
        //        if (item.ColorSala.ToString() == dataGridAula.CurrentRow.Cells[0].Value.ToString() &&   // PREGUNTAR A LUCAS COMO TOMAR LOS VALORES DE UNA CELDA PARA COMPARA CON AULAS EXISTENTES
        //            item.Turno.ToString() == dataGridAula.CurrentRow.Cells[1].Value.ToString() 
        //            )
        //        {
        //            unAula = item;
        //        }
        //    }

        //    instAula = new FrmAltaAula(unAula);
        //    if (instAula.ShowDialog() == DialogResult.OK)
        //    {

        //    }
        //}
    }//
}//
