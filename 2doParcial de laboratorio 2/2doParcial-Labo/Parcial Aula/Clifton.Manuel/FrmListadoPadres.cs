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
    public partial class FrmListadoPadres : Form
    {

        List<Aula> listAulas;
        public FrmListadoPadres( List<Aula> aulas)
        {
            InitializeComponent();

            listAulas = aulas;
        }

        private void FrmListadoPadres_Load(object sender, EventArgs e)
        {
            cmbTurno.DataSource = Enum.GetNames(typeof(ETurno));
            dataGridResponsable.ReadOnly = true;
            dataGridResponsable.AllowUserToAddRows = false;
            dataGridResponsable.RowHeadersVisible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbAulas.SelectedIndex != -1 && cmbTurno.SelectedIndex != -1)
            {
                EColor color = EColor.SinSala;
                switch (cmbAulas.Text)
                {
                    case "Naranja":
                        color = EColor.Naranja;
                        break;
                    case "Rojo":
                        color = EColor.Rojo;
                        break;
                    case "Amarillo":
                        color = EColor.Amarillo;
                        break;
                    case "Verde":
                        color = EColor.Verde;
                        break;
                    default:
                        break;
                }

                ETurno turno = ETurno.Mañana;
                switch (cmbTurno.Text)
                {
                    case "Mañana":
                        turno = ETurno.Mañana;
                        break;
                    case "Tarde":
                        turno = ETurno.Tarde;
                        break;

                    default:
                        break;
                }
                bool existe = false;

                foreach (Aula item in listAulas)
                {
                    if (item.ColorSala == color && item.Turno == turno)
                    {

                        this.dataGridResponsable.Rows.Clear();
                        int fila = 0;
                        foreach (Alumno Aux in item.Alumnos)
                        {
                            if (Aux.ColorSala == color && item.Turno == turno)
                            {
                                fila = dataGridResponsable.Rows.Add();
                                dataGridResponsable.Rows[fila].Cells[0].Value = Aux.Responsable.Nombre;
                                dataGridResponsable.Rows[fila].Cells[1].Value = Aux.Responsable.Apellido;
                                dataGridResponsable.Rows[fila].Cells[2].Value = Aux.Responsable.Telefono;
                            }
                            existe = true;
                        }
                    }
                    
                }

                if (!existe)
                {

                    MessageBox.Show($"No existe el Aula color {color} en el turno {turno}");
                }
            }
            else
            {
                MessageBox.Show("Seleccionar Aula y Turno");
            }
        }










    }//
}//
