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
    public partial class FrmBaja : Form
    {
        private List<Alumno> listAlumnosConAula;
        private List<Alumno> listAlumnosSinAula;
        private List<Responsable> listResponsables;
        private List<Docente> listDocentes;
        private List<Administrativo> listAdministrativos;
        private List<Aula> listAulas;

        private Alumno unAlumno;
        private Responsable unResponsable;

        private Docente unDocente;
        private Administrativo unAdministrativo;

        private int flag;


        public FrmBaja()
        {
            InitializeComponent();
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
        public List<Docente> ListDocentes
        {
            get { return this.listDocentes; }
            set { this.listDocentes = value; }
        }
        public List<Administrativo> ListAdministrativo
        {
            get { return this.listAdministrativos; }
            set { this.listAdministrativos = value; }
        }
        public List<Aula> ListAulas
        {
            get { return this.listAulas; }
            set { this.listAulas = value; }
        }
        
        public void CargarFormAlumno()
        {
            Lb_BajaCliente.Text = "Baja de Alumno";
            flag = 1;
        }
        public void CargarFormResponsable()
        {
            Lb_BajaCliente.Text = "Baja de Responsable";
            flag = 2;
        }
        public void CargarFormDocente()
        {
            Lb_BajaCliente.Text = "Baja de Docente";
            flag = 3;
        }
        public void CargarFormAdministrativo()
        {
            Lb_BajaCliente.Text = "Baja de Administrativo";
            flag = 4;
        }

        private void btnConfirmarBaja_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarString(txtDni.Text) &&
                Validaciones.ValidarString(txtNombre.Text) &&
                Validaciones.ValidarString(txtDni.Text))
            {
                if (MessageBox.Show("Estas Seguro ?. Los datos eliminados no pueden recuperarse.", "Baja", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    MessageBox.Show("Baja Cancelada");
                }
                else
                {
                    if (flag == 1)
                    {
                        BajaAlumno();
                    }
                    else if(flag == 2)
                    {
                        BajaResponsable();
                    }else if (flag == 3)
                    {
                        BajaDocente();
                    }
                    else
                    {
                        BajaAdministrativo();
                    }

                }
            }
        }

        private void BajaAlumno()
        {
            if (ValidarCampos())
            {
                if (VerificarSiExisteAlumno())
                {
                    if (index == 1)
                    {
                        
                        // recorrer las aulas y remover al alumno
                        for (int i = 0; i < ListAulas.Count; i++)
                        {
                            for (int j = 0; j < ListAulas[i].Alumnos.Count; j++)
                            {
                                if (unAlumno == ListAulas[i].Alumnos[j])
                                {
                                    ListAulas[i].Alumnos.Remove(ListAulas[i].Alumnos[j]);
                                }
                            }
                        }
                        ListAlumnosConAula.Remove(unAlumno);
                        MessageBox.Show($"Se dio de Baja a {unAlumno.Nombre}, {unAlumno.Apellido}");
                    }
                    if (index == 2)
                    {
                        ListAlumnosSinAula.Remove(unAlumno);
                        MessageBox.Show($"Se dio de Baja a {unAlumno.Nombre}, {unAlumno.Apellido}");
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No Existe el Alumno");
                }
            }  
        }

        private void BajaResponsable()
        {
            if (ValidarCampos())
            {
                if (VerificarSiExisteResponsable())
                {
                    for (int i = 0; i < ListAlumnosConAula.Count; i++)
                    {
                        if (ListAlumnosConAula[i].Responsable == unResponsable)
                        {
                            ListAlumnosConAula[i].Responsable = null;

                            MessageBox.Show($"Se dio de Baja al responsable {unResponsable.Nombre}, {unResponsable.Apellido}.\nEl Alumno {ListAlumnosConAula[i].Nombre}, {ListAlumnosConAula[i].Apellido} necesita que le asignen un nuevo responsable. URGENTE!!");
                        }
                    }

                    for (int i = 0; i < ListAlumnosSinAula.Count; i++)
                    {
                        if (ListAlumnosSinAula[i].Responsable == unResponsable)
                        {
                            ListAlumnosSinAula[i].Responsable = null;
                            MessageBox.Show($"Se dio de Baja al responsable {unResponsable.Nombre}, {unResponsable.Apellido}.\nEl Alumno {ListAlumnosSinAula[i].Nombre}, {ListAlumnosSinAula[i].Apellido} necesita que le asignen un nuevo responsable. URGENTE!!");
                        }
                    }
                    ListResponsables.Remove(unResponsable);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("No Existe el Responsable");
                }
            }       
        }

        private void BajaDocente()
        {
            if (ValidarCampos())
            {
                if (VerificarSiExisteDocennte())
                {
                    if (VerificarDocenteActivo())
                    {
                        MessageBox.Show($"No se pudo realizar la Baja.\nEl Docente: {unDocente.Nombre}, {unDocente.Apellido} tiene aulas asignadas.");
                    }
                    else
                    {
                        MessageBox.Show($"Se dio de Baja al Docente: {unDocente.Nombre}, {unDocente.Apellido}");
                        ListDocentes.Remove(unDocente);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("No Existe el Responsable");
                }
            }
        }

        private void BajaAdministrativo()
        {
            if (ValidarCampos())
            {
                if (VerificarSiExisteAdministrativo())
                {
                    MessageBox.Show($"Se dio de Baja al Administrativo: {unAdministrativo.Nombre}, {unAdministrativo.Apellido}");
                    ListAdministrativo.Remove(unAdministrativo);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No Existe el Responsable");
                }
            }
        }


        private bool ValidarCampos()
        {
            if (Validaciones.ValidarString(txtApellido.Text) &&
                Validaciones.ValidarString(txtNombre.Text) &&
                Validaciones.ValidarString(txtDni.Text))
            {
                if (Validaciones.ValidarStringSoloLetras(txtNombre.Text) &&
                    Validaciones.ValidarStringSoloLetras(txtApellido.Text))
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
        private bool VerificarDocenteActivo()
        {
            foreach (Aula item in ListAulas)
            {
                if (item.Docente == unDocente)
                {
                    return true;
                }
            }
            return false;
        }

        private bool VerificarSiExisteDocennte()
        {
            for (int i = 0; i < ListDocentes.Count; i++)
            {
                if (ListDocentes[i].Dni == Convert.ToInt64(txtDni.Text) && ListDocentes[i].Nombre == txtNombre.Text && ListDocentes[i].Apellido == txtApellido.Text)
                {
                    unDocente = ListDocentes[i];
                    return true;
                }
            }
            return false;
        }

        int index = 0;

        private bool VerificarSiExisteAlumno()
        {
            for (int i = 0; i < ListAlumnosConAula.Count; i++)
            {
                if (ListAlumnosConAula[i].Dni == Convert.ToInt64(txtDni.Text) && ListAlumnosConAula[i].Nombre == txtNombre.Text && ListAlumnosConAula[i].Apellido == txtApellido.Text)
                {
                    unAlumno = ListAlumnosConAula[i];
                    index = 1;
                    return true;
                }
            }

            for (int i = 0; i < ListAlumnosSinAula.Count; i++)
            {
                if (ListAlumnosSinAula[i].Dni == Convert.ToInt64(txtDni.Text) && ListAlumnosSinAula[i].Nombre == txtNombre.Text && ListAlumnosSinAula[i].Apellido == txtApellido.Text)
                {
                    unAlumno = ListAlumnosSinAula[i];
                    index = 2;
                    return true;
                }
            }

            return false;
        }

        private bool VerificarSiExisteResponsable()
        {
            for (int i = 0; i < ListResponsables.Count; i++)
            {
                if (ListResponsables[i].Dni == Convert.ToInt64(txtDni.Text) && ListResponsables[i].Nombre == txtNombre.Text && ListResponsables[i].Apellido == txtApellido.Text)
                {
                    unResponsable = ListResponsables[i];
                    return true;
                }
            }
            return false;
        }

       
        private bool VerificarSiExisteAdministrativo()
        {
            for (int i = 0; i < ListAdministrativo.Count; i++)
            {
                if (ListAdministrativo[i].Dni == Convert.ToInt64(txtDni.Text) && ListAdministrativo[i].Nombre == txtNombre.Text && ListAdministrativo[i].Apellido == txtApellido.Text)
                {
                    unAdministrativo = ListAdministrativo[i];
                    return true;
                }
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }





        // FALTA FUNCIONALIDAD EN LOS BOTONES Y DAR DE BAJA CON EL NUMERO DE INDEX SI ES QUE EXISTE.

    }//
}//
