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
    public partial class FrmAlumnosPorAula : Form
    {
        List<Alumno> listAlumnosConAula;
        List<Aula> listAulas;
        
        public FrmAlumnosPorAula()
        {
            InitializeComponent();
        }

        public FrmAlumnosPorAula(List<Alumno> alumnos, List<Aula> aulas):this()
        {
            listAlumnosConAula = alumnos;
            listAulas = aulas;
        }

        private void FrmAlumnosPorAula_Load(object sender, EventArgs e)
        {
            cmbTurno.DataSource = Enum.GetNames(typeof(ETurno));
            dataGridAlumnos.ReadOnly = true;
            dataGridAlumnos.AllowUserToAddRows = false;
            dataGridAlumnos.RowHeadersVisible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            float recaudacion = 0;
            Lb_RecaudacionPorAula.Text = "Recaucación: ";
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
                        existe = true;
                        Lb_ProfesorACargo.Text = $"Docente a Cargo: {item.Docente.Nombre} {item.Docente.Apellido}";

                        this.dataGridAlumnos.Rows.Clear();
                        int fila = 0;

                        foreach (Alumno Aux in item.Alumnos)
                        {

                                fila = dataGridAlumnos.Rows.Add();
                                dataGridAlumnos.Rows[fila].Cells[0].Value = Aux.Nombre;
                                dataGridAlumnos.Rows[fila].Cells[1].Value = Aux.Apellido;
                                dataGridAlumnos.Rows[fila].Cells[2].Value = Aux.Dni;
                                if (Aux.Femenino)
                                {
                                    dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                                }
                                else
                                {
                                    dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                                }

                                dataGridAlumnos.Rows[fila].Cells[4].Value = Aux.PrecioCuota;
                                
                                recaudacion += Aux.PrecioCuota;
                            
                        }
                        Lb_RecaudacionPorAula.Text += recaudacion.ToString();
                        if (existe)
                        {
                            break;
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

        }//..
    }//
}//
