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
    public partial class FrmEditarAdministrativo : Form
    {
        List<Administrativo> listAdministrativos;
        List<Docente> listDocentes;

        Administrativo editarAdministrativo;

        public FrmEditarAdministrativo()
        {
            editarAdministrativo = new Administrativo();
            InitializeComponent();
        }

        public List<Administrativo> ListAdministrativos
        {
            get { return this.listAdministrativos; }
            set { this.listAdministrativos = value; }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //TERMINAR EDICION    MEJORAR CMBCARGOS PARA QUE NO EMPIECE CON NINGUNO.
            if (ValidarCampos())
            {
                ListAdministrativos[indiceAdmin].Nombre = txtNombre.Text;
                listAdministrativos[indiceAdmin].Apellido = txtApellido.Text;
                listAdministrativos[indiceAdmin].Dni = int.Parse(txtDni.Text);
                if (cmbSexo.SelectedIndex != -1)
                {
                    if (cmbSexo.Text == "Femenino")
                    {
                        listAdministrativos[indiceAdmin].Femenino = true;
                    }
                    else
                    {
                        listAdministrativos[indiceAdmin].Femenino = false;

                    }
                    
                }
                listAdministrativos[indiceAdmin].HoraEntrada = dateTimeHrEntrada.Value;
                listAdministrativos[indiceAdmin].HoraSalida = dateTimeHrSalida.Value;
                listAdministrativos[indiceAdmin].Cargo = (ECargo)cmbCargo.SelectedIndex;

            }
        }

        private void FrmEditarAdministrativo_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Enum.GetNames(typeof(ECargo));

            Lb_Editar.Text = "Editar Personal";

            btnEditar.Enabled = false;
            dataGridNoDocente.ReadOnly = true;
        }


        int indiceAdmin = -1;

        private void dataGridNoDocente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flag = true;
            int contador = 0;

            txtNombre.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtApellido.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtDni.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cmbSexo.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dateTimeHrEntrada.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[4].Value.ToString();
            dateTimeHrSalida.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[5].Value.ToString();
            cmbCargo.Text = dataGridNoDocente.Rows[dataGridNoDocente.CurrentCell.RowIndex].Cells[6].Value.ToString();

            foreach (Administrativo item in listAdministrativos)
            {
                if (item.Dni == int.Parse(txtDni.Text))
                {
                    editarAdministrativo.Nombre = item.Nombre;
                    editarAdministrativo.Apellido = item.Apellido;
                    editarAdministrativo.Dni = item.Dni;
                    editarAdministrativo.Femenino = item.Femenino;
                    editarAdministrativo.HoraEntrada = item.HoraEntrada;
                    editarAdministrativo.HoraSalida = item.HoraSalida;
                    editarAdministrativo.Cargo = item.Cargo;


                    indiceAdmin = contador;

                    break;
                }
                contador++;
            }

            btnEditar.Enabled = true;
        }

        private bool flag = false;
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
            if (flag == false)
            {
                this.dataGridNoDocente.Rows.Clear();
                int fila = 0;
                foreach (Administrativo item in listAdministrativos)
                {
                    if (item.Nombre.Contains(txtNombre.Text))
                    {
                        fila = dataGridNoDocente.Rows.Add();
                        dataGridNoDocente.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridNoDocente.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridNoDocente.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridNoDocente.Rows[fila].Cells[4].Value = item.Entrada;
                        dataGridNoDocente.Rows[fila].Cells[5].Value = item.Salida;
                        dataGridNoDocente.Rows[fila].Cells[6].Value = item.Cargo;
                    }
                }

                if (txtNombre.Text == string.Empty)
                {
                    this.dataGridNoDocente.Rows.Clear();
                }
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
            if (flag == false)
            {
                this.dataGridNoDocente.Rows.Clear();
                int fila = 0;
                foreach (Administrativo item in listAdministrativos)
                {
                    if (item.Apellido.Contains(txtApellido.Text))
                    {
                        fila = dataGridNoDocente.Rows.Add();
                        dataGridNoDocente.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridNoDocente.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridNoDocente.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridNoDocente.Rows[fila].Cells[4].Value = item.Entrada;
                        dataGridNoDocente.Rows[fila].Cells[5].Value = item.Salida;
                        dataGridNoDocente.Rows[fila].Cells[6].Value = item.Cargo;
                    }
                }

                if (txtApellido.Text == string.Empty)
                {
                    this.dataGridNoDocente.Rows.Clear();
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDni.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
            if (flag == false)
            {
                this.dataGridNoDocente.Rows.Clear();
                int fila = 0;
                foreach (Administrativo item in listAdministrativos)
                {
                    if (item.Dni.ToString().Contains(txtDni.Text))
                    {
                        fila = dataGridNoDocente.Rows.Add();
                        dataGridNoDocente.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridNoDocente.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridNoDocente.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridNoDocente.Rows[fila].Cells[4].Value = item.Entrada;
                        dataGridNoDocente.Rows[fila].Cells[5].Value = item.Salida;
                        dataGridNoDocente.Rows[fila].Cells[6].Value = item.Cargo;
                    }
                }

                if (txtDni.Text == string.Empty)
                {
                    this.dataGridNoDocente.Rows.Clear();
                }
            }
        }

        private void cmbCargo_TextChanged(object sender, EventArgs e)
        {
            int entero = 0;
            switch (cmbCargo.SelectedIndex)
            {
                case 0:
                    entero = 100;
                    break;
                case 1:
                    entero = 110;
                    break;
                case 2:
                    entero = 140;
                    break;
                case 3:
                    entero = 180;
                    break;
                case 4:
                    entero = 240;
                    break;
                default:
                    break;
            }
            ECargo cargo = (ECargo)entero;

            if (flag == false)
            {
                this.dataGridNoDocente.Rows.Clear();
                int fila = 0;
                foreach (Administrativo item in listAdministrativos)
                {
                    if (item.Cargo == cargo)
                    {
                        fila = dataGridNoDocente.Rows.Add();
                        dataGridNoDocente.Rows[fila].Cells[0].Value = item.Nombre;
                        dataGridNoDocente.Rows[fila].Cells[1].Value = item.Apellido;
                        dataGridNoDocente.Rows[fila].Cells[2].Value = item.Dni;
                        if (item.Femenino)
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Femenino";
                        }
                        else
                        {
                            dataGridNoDocente.Rows[fila].Cells[3].Value = "Masculino";
                        }
                        dataGridNoDocente.Rows[fila].Cells[4].Value = item.Entrada;
                        dataGridNoDocente.Rows[fila].Cells[5].Value = item.Salida;
                        dataGridNoDocente.Rows[fila].Cells[6].Value = item.Cargo;
                    }
                }

                if (cmbCargo.Text == string.Empty)
                {
                    this.dataGridNoDocente.Rows.Clear();
                }
            }
        }

        private bool ValidarCampos()
        {
            if (Validaciones.ValidarString(txtNombre.Text) &&
                    Validaciones.ValidarString(txtApellido.Text) &&
                    Validaciones.ValidarString(txtDni.Text) &&
                    Validaciones.ValidarString(dateTimeHrEntrada.Text) &&
                    Validaciones.ValidarString(dateTimeHrSalida.Text) &&
                     cmbSexo.SelectedIndex != -1 &&
                     !(cmbCargo.SelectedIndex == -1)
                    )
            {
                if (Validaciones.ValidarStringSoloLetras(txtNombre.Text) &&
                    Validaciones.ValidarStringSoloLetras(txtApellido.Text))
                {
                    if (dateTimeHrEntrada.Text != dateTimeHrSalida.Text && string.Compare(dateTimeHrEntrada.Text, dateTimeHrSalida.Text) == -1)
                    {
                        if ((cmbSexo.Text == "Femenino" || cmbSexo.Text == "Masculino"))
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
                            MessageBox.Show("Seleccione un sexo");
                            return false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Hora de entrada y salida invalida");
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
