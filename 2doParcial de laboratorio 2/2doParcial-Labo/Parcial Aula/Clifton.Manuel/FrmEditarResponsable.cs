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
    public partial class FrmEditarResponsable : Form
    {
        private List<Alumno> listAlumnosConAula;
        private List<Alumno> listAlumnosSinAula;
        private List<Responsable> listResponsables;
        private List<Aula> listAulas;

        private Responsable unResponsable;
        private Responsable eliminarResponsable;

        public FrmEditarResponsable()
        {
            InitializeComponent();
            unResponsable = new Responsable();
            eliminarResponsable = new Responsable();
        }
       
        public List<Alumno> ListAlumnosConAula
        {
            get { return this.listAlumnosConAula; }
            set { this.listAlumnosConAula = value; }
        }
        public List<Alumno> ListAlumnosSinAula
        {
            get { return this.listAlumnosSinAula; }
            set { this.listAlumnosSinAula = value; }
        }
        public List<Responsable> ListResponsables
        {
            get { return this.listResponsables; }
            set { this.listResponsables = value; }
        }
        public List<Aula> ListAulas
        {
            get { return this.listAulas; }
            set { this.listAulas = value; }
        }

        private void FrmEditarResponsable_Load(object sender, EventArgs e)
        {
            Lb_Editar.Text = "Editar Responsable";
            btnEditar.Enabled = false;
            //dataGridResponsable.ReadOnly = true;
        }


       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ListResponsables[indiceResposable].Nombre = txtNombre.Text;
                ListResponsables[indiceResposable].Apellido = txtApellido.Text;
                ListResponsables[indiceResposable].Dni = int.Parse(txtDni.Text);
                ListResponsables[indiceResposable].Telefono = txtTelefono.Text;

                //this.unResponsable.Nombre = txtNombre.Text;
                //this.unResponsable.Apellido = txtApellido.Text;
                //this.unResponsable.Dni = int.Parse(txtDni.Text);
                //this.unResponsable.Telefono = txtTelefono.Text;


                //ListResponsables.Remove(eliminarResponsable);
                //ListResponsables.Add(unResponsable);

                foreach (Aula item1 in ListAulas)
                {
                    foreach (Alumno item2 in item1.Alumnos)
                    {
                         if (item2.Responsable == unResponsable)
                        {
                            item2.Responsable = ListResponsables[indiceResposable];
                        }
                    }
                }
                foreach (Alumno item in ListAlumnosConAula)
                {
                    if (item.Responsable == unResponsable)
                    {
                        item.Responsable = ListResponsables[indiceResposable];
                    }
                }
                foreach (Alumno item in ListAlumnosSinAula)
                {
                    if (item.Responsable == unResponsable)
                    {
                        item.Responsable = ListResponsables[indiceResposable];
                    }
                }

              

                MessageBox.Show("Se Edito el Responsable correctamente");
                DialogResult = DialogResult.OK;
            }
        }
        int indiceResposable = -1;
        private void dataGridResponsable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flag = true;
            int contador = 0;

            txtNombre.Text = dataGridResponsable.Rows[dataGridResponsable.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtApellido.Text = dataGridResponsable.Rows[dataGridResponsable.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtDni.Text = dataGridResponsable.Rows[dataGridResponsable.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtTelefono.Text = dataGridResponsable.Rows[dataGridResponsable.CurrentCell.RowIndex].Cells[5].Value.ToString();

                foreach (Responsable item in ListResponsables)
                {
                    if (item.Dni == int.Parse(txtDni.Text))
                    {
                        unResponsable.Nombre = item.Nombre;
                        unResponsable.Apellido = item.Apellido;
                        unResponsable.Dni = item.Dni;
                        unResponsable.Telefono = item.Telefono;
                        unResponsable.Parentesco = item.Parentesco;
                        unResponsable.Femenino = item.Femenino;

                        indiceResposable = contador;

                        break;
                    }
                contador++;
            }

                btnEditar.Enabled = true;         
        }

        private bool flag = false; // Si selecciono un alumno, Ya no busca mas y permite editar
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
             
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;

            if (flag == false)
            {
                this.dataGridResponsable.Rows.Clear();
                int fila = 0;
                foreach (Responsable item in ListResponsables)
                {
                    if (item.Nombre.Contains(txtNombre.Text))
                    {
                        fila = dataGridResponsable.Rows.Add();
                        dataGridResponsable.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridResponsable.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridResponsable.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridResponsable.Rows[fila].Cells[4].Value = item.Parentesco;
                        dataGridResponsable.Rows[fila].Cells[5].Value = item.Telefono;
                    }
                }


                if (txtNombre.Text == string.Empty)
                {
                    this.dataGridResponsable.Rows.Clear();
                }
        }
    }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtApellido.SelectionStart = txtApellido.Text.Length;

            if (flag == false)
            {
                this.dataGridResponsable.Rows.Clear();
                int fila = 0;
                foreach (Responsable item in ListResponsables)
                {
                    if (item.Apellido.Contains(txtApellido.Text))
                    {
                        fila = dataGridResponsable.Rows.Add();
                        dataGridResponsable.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridResponsable.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridResponsable.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridResponsable.Rows[fila].Cells[4].Value = item.Parentesco;
                        dataGridResponsable.Rows[fila].Cells[5].Value = item.Telefono;
                    }
                }


                if (txtApellido.Text == string.Empty)
                {
                    this.dataGridResponsable.Rows.Clear();
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDni.Text);
            txtDni.SelectionStart = txtDni.Text.Length;

            if (flag == false)
            {
                this.dataGridResponsable.Rows.Clear();
                int fila = 0;
                foreach (Responsable item in ListResponsables)
                {
                    if (item.Dni.ToString().Contains(txtDni.Text))
                    {
                        fila = dataGridResponsable.Rows.Add();
                        dataGridResponsable.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridResponsable.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridResponsable.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridResponsable.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridResponsable.Rows[fila].Cells[4].Value = item.Parentesco;
                        dataGridResponsable.Rows[fila].Cells[5].Value = item.Telefono;
                    }
                }


                if (txtDni.Text == string.Empty)
                {
                    this.dataGridResponsable.Rows.Clear();
                }
            }
        }

       

        private bool ValidarCampos()
        {
            if (Validaciones.ValidarString(txtApellido.Text) &&
                Validaciones.ValidarString(txtNombre.Text) &&
                Validaciones.ValidarString(txtDni.Text) &&
                Validaciones.ValidarString(txtTelefono.Text))
            {
                if (Validaciones.ValidarStringSoloLetras(txtNombre.Text) &&
                    Validaciones.ValidarStringSoloLetras(txtApellido.Text))
                {
                    if (Validaciones.ValidarStringSoloNumeros(txtTelefono.Text))
                    {
                        if (Validaciones.ValidarStringSoloNumeros(txtDni.Text) &&
                            (Convert.ToInt64(txtDni.Text) >= 1000000 && Convert.ToInt64(txtDni.Text) <= 99999999))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("DNI Invalido");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telefono Invalido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Nombre o Apellido mal escritos, solo debe contener letras.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Todos los cambos deben estar completos.");
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }//
}//
