using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clifton.Manuel
{
    public partial class FrmDocente : Form
    {
        List<Docente> listaDocente;

        public FrmDocente()
        {
            InitializeComponent();
        }

        public FrmDocente(List<Docente> docentes):this()
        {
            listaDocente = docentes;
            CargarTabla();
        }


        private void CargarTabla()
        {
                this.dataGridDocente.Rows.Clear();
                int fila = 0;
                foreach (Docente Aux in listaDocente)
                {
                    fila = dataGridDocente.Rows.Add();
                    dataGridDocente.Rows[fila].Cells[0].Value = Aux.Nombre;
                    dataGridDocente.Rows[fila].Cells[1].Value = Aux.Apellido;
                    dataGridDocente.Rows[fila].Cells[2].Value = Aux.Dni;
                    if (Aux.Femenino)
                    {
                    dataGridDocente.Rows[fila].Cells[3].Value = "Mujer";
                    }
                    else
                    {
                    dataGridDocente.Rows[fila].Cells[3].Value = "Hombre";
                    }
                    dataGridDocente.Rows[fila].Cells[4].Value = Aux.Entrada;
                    dataGridDocente.Rows[fila].Cells[5].Value = Aux.Salida;
                    dataGridDocente.Rows[fila].Cells[6].Value = Aux.ValorHora;
                }
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            dataGridDocente.ReadOnly = true;
            dataGridDocente.AllowUserToAddRows = false;
            dataGridDocente.RowHeadersVisible = false;
        }
    }//
}//
