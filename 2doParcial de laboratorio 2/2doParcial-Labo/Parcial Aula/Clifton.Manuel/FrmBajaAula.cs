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
    public partial class FrmBajaAula : Form
    {

        private List<Alumno> listAlumnosSinAula;
        private List<Alumno> listAlumnosConAula;
        private List<Aula> listAulas;

        public FrmBajaAula()
        {
            InitializeComponent();
        }

        public List<Alumno> ListAlumnosSinAula
        {
            get { return this.listAlumnosSinAula; }
            set { this.listAlumnosSinAula = value; }
        }
        public List<Alumno> ListAlumnosConAula
        {
            get { return this.listAlumnosConAula; }
            set { this.listAlumnosConAula = value; }
        }
        public List<Aula> ListAulas
        {
            get { return this.listAulas; }
            set { this.listAulas = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmBajaAula_Load(object sender, EventArgs e)
        {
            cmbTurno.DataSource = Enum.GetNames(typeof(ETurno));
        }


        // REVISAR PORQUE NO ELIMINA A LOS ALUMNOS DE LA LISTA DE ALUMNOS CON AULA
        private void btnConfirmarBaja_Click(object sender, EventArgs e)
        {
            Aula eliminarAula = this.ValidarAula();

            if (!(eliminarAula is null))
            {
                //foreach (Alumno item in eliminarAula.Alumnos)
                //{
                //        ListAlumnosConAula.Remove(item);
                //        item.ColorSala = EColor.SinSala;
                //        ListAlumnosSinAula.Add(item);
                //}
                foreach (Alumno item in ListAlumnosConAula)
                {
                    if (eliminarAula.Alumnos.Contains(item))
                    {
                        ListAlumnosConAula.Remove(item);
                        item.ColorSala = EColor.SinSala;

                        ListAlumnosSinAula.Add(item);
                    }
                }
                this.ListAulas.Remove(eliminarAula);
                MessageBox.Show("Aula Eliminada.");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Aula no existe");
            }
            
        }


        private Aula ValidarAula()
        {
            EColor color = this.CargarColor();
            ETurno turno = this.CargarTurno();
            foreach (Aula item in ListAulas)
            {
                if (item.ColorSala == color && item.Turno == turno)
                {
                    return item;
                }
            }
            return null;
        }


        private EColor CargarColor()
        {
            EColor color = EColor.SinSala;
            switch (cmbColores.Text)
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
            return color;

        }
        /// <summary>
        /// Carga la variable de tipo ETurno segun lo seleccionado en cmbTurno
        /// </summary>
        /// <returns>ETurno</returns>
        private ETurno CargarTurno()
        {
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
            return turno;
        }




    }//
}//
