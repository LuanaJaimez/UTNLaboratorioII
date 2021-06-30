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
    public partial class FrmEditarAlumno : Form
    {

        private List<Alumno> listAlumnosConAula;
        private List<Alumno> listAlumnosSinAula;
        private List<Responsable> listResponsables;
        private List<Aula> listAulas;

        private Alumno editarAlumno;

        public FrmEditarAlumno()
        {
            InitializeComponent();
            editarAlumno = new Alumno();
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

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            foreach (Responsable item in ListResponsables)
            {
                cmbResponsable.Items.Add($"{item.Nombre}, {item.Apellido}");
            }
            Lb_Editar.Text = "Editar Alumno";

            btnEditarAlumno.Enabled = false;
            dataGridAlumnos.ReadOnly = true;
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (editarAlumno.ColorSala == EColor.SinSala)
                {


                    ListAlumnosSinAula[indiceAlumno].Nombre = txtNombre.Text;
                    ListAlumnosSinAula[indiceAlumno].Apellido = txtApellido.Text;
                    ListAlumnosSinAula[indiceAlumno].Dni = int.Parse(txtDni.Text);
                    ListAlumnosSinAula[indiceAlumno].PrecioCuota = float.Parse(txtImporte.Text);

                    if (cmbResponsable.SelectedIndex != -1)
                    {
                        for (int i = 0; i < ListResponsables.Count; i++)
                        {
                            if (cmbResponsable.SelectedIndex == i)
                            {
                                ListAlumnosSinAula[indiceAlumno].Responsable = ListResponsables[i];
                            }
                        }
                    }
                }
                else
                {

                    listAlumnosConAula[indiceAlumno].Nombre = txtNombre.Text;
                    listAlumnosConAula[indiceAlumno].Apellido = txtApellido.Text;
                    listAlumnosConAula[indiceAlumno].Dni = int.Parse(txtDni.Text);
                    listAlumnosConAula[indiceAlumno].PrecioCuota = float.Parse(txtImporte.Text);
                   
                    if (cmbResponsable.SelectedIndex != -1)
                    {
                        for (int i = 0; i < ListResponsables.Count; i++)
                        {
                            if (cmbResponsable.SelectedIndex == i)
                            {
                                listAlumnosConAula[indiceAlumno].Responsable = ListResponsables[i];
                            }
                        }
                    }
                
                    foreach (Aula item in ListAulas)
                    {
                        if (item.ColorSala == listAlumnosConAula[indiceAlumno].ColorSala)
                        {
                            for (int i = 0; i < item.Alumnos.Count; i++)
                            {
                                if (item.Alumnos[i] == editarAlumno)
                                {
                                    item.Alumnos[i] = listAlumnosConAula[indiceAlumno];
                                }
                            }
                        }
                    }


                }

                MessageBox.Show("Se Edito el Alumno correctamente");
                DialogResult = DialogResult.OK;
            }
        }

        int indiceAlumno = -1;
        private void dataGridAlumnos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flag = true;
            int contador = 0;
            cmbResponsable.SelectedIndex = -1;
            cmbResponsable.Text = "";

            //ARREGLAR EXCEPCION AL SELECCIONAR ROW SI ESTA BACIO.
            txtNombre.Text = dataGridAlumnos.Rows[dataGridAlumnos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtApellido.Text = dataGridAlumnos.Rows[dataGridAlumnos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtDni.Text = dataGridAlumnos.Rows[dataGridAlumnos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtImporte.Text = dataGridAlumnos.Rows[dataGridAlumnos.CurrentCell.RowIndex].Cells[4].Value.ToString();

            foreach (Alumno item in ListAlumnosConAula)
            {
                if (item.Dni == int.Parse(txtDni.Text))
                {
                    editarAlumno.Nombre = item.Nombre;
                    editarAlumno.Apellido = item.Apellido;
                    editarAlumno.Dni = item.Dni;
                    editarAlumno.ColorSala = item.ColorSala;
                    editarAlumno.Responsable = item.Responsable ;
                    editarAlumno.Legajo = item.Legajo;
                    editarAlumno.Femenino = item.Femenino;
                    editarAlumno.PrecioCuota = item.PrecioCuota;

                    indiceAlumno = contador;
                    
                    break;
                }
                contador++;
            }

            if (indiceAlumno == -1)
            {
                contador = 0;

                foreach (Alumno item in ListAlumnosSinAula)
                {
                    if (item.Dni == int.Parse(txtDni.Text))
                    {
                        editarAlumno.Nombre = item.Nombre;
                        editarAlumno.Apellido = item.Apellido;
                        editarAlumno.Dni = item.Dni;
                        editarAlumno.ColorSala = item.ColorSala;
                        editarAlumno.Responsable = item.Responsable;
                        editarAlumno.Legajo = item.Legajo;
                        editarAlumno.Femenino = item.Femenino;
                        editarAlumno.PrecioCuota = item.PrecioCuota;

                        indiceAlumno = contador;

                        break;
                    }
                    contador++;
                }
            }
            
            txtResponsable.Text = $"{editarAlumno.Responsable.Nombre} { editarAlumno.Responsable.Apellido}";

            btnEditarAlumno.Enabled = true;
        }

        private bool flag = false; // Si selecciono un alumno, Ya no busca mas y permite editar
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
            if (flag == false)
            {
                this.dataGridAlumnos.Rows.Clear();
                int fila = 0;
                foreach (Alumno item in listAlumnosConAula)
                {
                    if (item.Nombre.Contains(txtNombre.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }
                foreach (Alumno item in listAlumnosSinAula)
                {
                    if (item.Nombre.Contains(txtNombre.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }

                if (txtNombre.Text == string.Empty)
                {
                    this.dataGridAlumnos.Rows.Clear();
                }
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtApellido.SelectionStart = txtApellido.Text.Length;
            if (flag == false)
            {
                this.dataGridAlumnos.Rows.Clear();
                int fila = 0;
                foreach (Alumno item in listAlumnosConAula)
                {
                    if (item.Apellido.Contains(txtApellido.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }
                foreach (Alumno item in listAlumnosSinAula)
                {
                    if (item.Apellido.Contains(txtApellido.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }

                if (txtApellido.Text == string.Empty)
                {
                    this.dataGridAlumnos.Rows.Clear();
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.dataGridAlumnos.Rows.Clear();
                int fila = 0;
                foreach (Alumno item in listAlumnosConAula)
                {
                    if (item.Dni.ToString().Contains(txtDni.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }
                foreach (Alumno item in listAlumnosSinAula)
                {
                    if (item.Dni.ToString().Contains(txtDni.Text))
                    {
                        fila = dataGridAlumnos.Rows.Add();
                        dataGridAlumnos.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridAlumnos.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridAlumnos.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridAlumnos.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridAlumnos.Rows[fila].Cells[4].Value = item.PrecioCuota;
                        dataGridAlumnos.Rows[fila].Cells[5].Value = item.ColorSala;
                    }
                }

                if (txtDni.Text == string.Empty)
                {
                    this.dataGridAlumnos.Rows.Clear();
                }
            }
        }

       
 

        private bool ValidarCampos()
        {
            if (Validaciones.ValidarString(txtApellido.Text) &&
                Validaciones.ValidarString(txtNombre.Text)   &&
                Validaciones.ValidarString(txtDni.Text)      &&
                Validaciones.ValidarString(txtImporte.Text)  &&
                Validaciones.ValidarString(txtResponsable.Text))
            {
                if (Validaciones.ValidarStringSoloLetras(txtNombre.Text) &&
                    Validaciones.ValidarStringSoloLetras(txtApellido.Text))
                {
                    if (Validaciones.ValidarStringSoloNumeros(txtImporte.Text) &&
                        Validaciones.ValidarFlotante(txtImporte.Text, 100000, 2499))
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
                        MessageBox.Show("Importe Invalido");
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

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResponsable.Text = cmbResponsable.Text;
        }
    }
}
