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
    public partial class FrmAltaAlumno : Form
    {
        private List<Responsable> listResponsables;
        private Alumno unAlumno;
        private int legajoAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }


        public List<Responsable> ListResponsables
        {
            get { return this.listResponsables; }
            set { this.listResponsables = value; }
        }
        public Alumno UnAlumno
        {
            get { return this.unAlumno; }
        }
        public int Legajo
        {
            get { return this.legajoAlumno; }
            set { this.legajoAlumno = value; }
        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            foreach (Responsable item in listResponsables)
            {
                listBoxResponsables.Items.Add($"{item.Nombre} {item.Apellido} - Parentesco: {item.Parentesco}");
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool sexo;
            if (Validaciones.ValidarString(txtNombre.Text) && // REVISAR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Validaciones.ValidarString(txtApellido.Text) &&
                Validaciones.ValidarString(txtDni.Text) &&
                Validaciones.ValidarString(cmbSexo.Text) &&
                Validaciones.ValidarString(numPrecio.Text) 
               )
            {
                if (this.listBoxResponsables.SelectedIndex != -1)
                {
                    if (Validaciones.ValidarEntero(txtDni.Text,99999999,1000000))
                    {
                        if (Validaciones.ValidarFlotante(numPrecio.Text, 100000, 2499))
                        {
                            if (cmbSexo.Text == "Femenino")
                            {
                                sexo = true;
                            }
                            else
                            {
                                sexo = false;
                            }
                            unAlumno = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), sexo, float.Parse(numPrecio.Value.ToString()));
                            unAlumno.Responsable = this.listResponsables[listBoxResponsables.SelectedIndex];
                            unAlumno.Legajo = legajoAlumno;
                            legajoAlumno++;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("El precio minimo es de 2500 y maximo 100000");
                        }
                    }else
                    {
                        MessageBox.Show("El DNI es invalido");
                    }
                    
                    
                }else
                {
                    MessageBox.Show("Debe seleccionar un responsable, porque llamamos a un asistente social para el NIÑE");
                }
               
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }//
}//
