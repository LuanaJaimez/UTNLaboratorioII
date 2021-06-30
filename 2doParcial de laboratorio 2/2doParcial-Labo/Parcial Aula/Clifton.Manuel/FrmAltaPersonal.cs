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

    public partial class FrmAltaPersonal : Form
    {
        private Docente unDocente;
        private Administrativo unNoDocente;
        private bool flag;

        public FrmAltaPersonal()
        {
            InitializeComponent();
        }

        public Docente UnDocente
        {
            get { return this.unDocente; }
        }
        public Administrativo UnNoDocente
        {
            get { return this.unNoDocente; }
        }
        //public FrmAlta(List<Docente> docentes):this()
        //{
        //    Lb_TipoDeAlta.Text = "Alta de Docente";

        //    Lb_Cargo.Visible = false;
        //    cmbCargo.Visible = false;
        //}


        //public FrmAlta(List<Administrativo> noDocente) : this()
        //{
        //    Lb_TipoDeAlta.Text = "Alta Administrativo";
        //    Lb_ValorHora.Visible = false;
        //    numValorHora.Visible = false;
        //}

        public void SetDocente()
        {
            Lb_TipoDeAlta.Text = "Alta de Docente";

            Lb_Cargo.Visible = false;
            cmbCargo.Visible = false;
            flag = true;
        }

        public void SetNoDocente()
        {
            Lb_TipoDeAlta.Text = "Alta Administrativo";
            Lb_ValorHora.Visible = false;
            numValorHora.Visible = false;
            flag = false;
        }



        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Enum.GetNames(typeof(ECargo));
        }

        private void AltaDocente()
        {
            bool sexo;
            if (Lb_TipoDeAlta.Text == "Alta de Docente")
            {
                if (Validaciones.ValidarString(txtNombre.Text) &&
                    Validaciones.ValidarString(txtApellido.Text) &&
                    Validaciones.ValidarString(txtDni.Text) &&
                    Validaciones.ValidarString(dateTimeHrEntrada.Text) &&
                    Validaciones.ValidarString(dateTimeHrSalida.Text) &&
                     cmbSexo.SelectedIndex != -1

                    )
                {
                    //if (Validaciones.ValidarString(txtNombre.Text) && Validaciones.ValidarString(txtApellido.Text) )
                    //{

                    //}
                    if (dateTimeHrEntrada.Text != dateTimeHrSalida.Text && string.Compare(dateTimeHrEntrada.Text, dateTimeHrSalida.Text) == -1 && (cmbSexo.Text == "Femenino" || cmbSexo.Text == "Masculino"))
                    {
                        if (Validaciones.ValidarEntero(txtDni.Text, 999999999, 1000000))
                        {
                            if (numValorHora.Value >= 0 && numValorHora.Value < 9999999)
                            {
                                if (cmbSexo.Text == "Femenino")
                                {
                                    sexo = true;
                                }
                                else
                                {
                                    sexo = false;
                                }
                                unDocente = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), sexo, Convert.ToDateTime(dateTimeHrEntrada.Value.ToString()), Convert.ToDateTime(dateTimeHrSalida.Value.ToString()), double.Parse(numValorHora.Value.ToString()));
                                if (!(unDocente is null))
                                {
                                    this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("Algo sucedio EL DOCENTE ES NULL. Reintentar");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Valor por Hora no puede ser negativo, ni mayor a  9999999");
                            }

                        }
                        else
                        {
                            MessageBox.Show("EL DNI DEBE SER UN NUMERO");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hora de entrada y salida invalida");
                    }


                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos");
                }

            }
        }


        private void AltaNoDocente()
        {
            bool sexo;
            if (Lb_TipoDeAlta.Text == "Alta Administrativo")
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
                    if (dateTimeHrEntrada.Text != dateTimeHrSalida.Text && string.Compare(dateTimeHrEntrada.Text, dateTimeHrSalida.Text) == -1 && (cmbSexo.Text == "Femenino" || cmbSexo.Text == "Masculino"))
                    {
                        if (Validaciones.ValidarEntero(txtDni.Text, 999999999, 1000000) && Validaciones.ValidarStringSoloNumeros(txtDni.Text))
                        {
                            if (cmbSexo.Text == "Femenino")
                            {
                                sexo = true;
                            }
                            else
                            {
                                sexo = false;
                            }
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

                            unNoDocente = new Administrativo(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), sexo, Convert.ToDateTime(dateTimeHrEntrada.Value.ToString()), Convert.ToDateTime(dateTimeHrSalida.Value.ToString()), (ECargo)entero);
                            if (!(unNoDocente is null))
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Algo sucedio EL No Docente ES NULL. Reintentar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL DNI DEBE SER UN NUMERO VALIDO");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hora de entrada y salida invalida o DNI invalido");
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos");
                }

            }
        }



        private void btnAgregar_Click(object sender, EventArgs e) /////////// ARREGLAR EL VALOR POR HORA
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
                if (flag)
                {
                    this.AltaDocente();
                }
                else
                {
                    this.AltaNoDocente();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            }

               

        }




        protected void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




    }//
}//
