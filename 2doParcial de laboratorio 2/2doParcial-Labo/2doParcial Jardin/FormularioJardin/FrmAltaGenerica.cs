using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioJardin
{
    public partial class FrmAltaGenerica : Form
    {
        bool cambioADocente;
        //bool cambioNoDocente;
        private string valorHora;
        private List<Alumno> lstAlumno;
        public FrmAltaGenerica()
        {
            this.cambioADocente = false;
            InitializeComponent();
        }
        public FrmAltaGenerica(List<Alumno> lstAlumno):this()
        { //
            this.lstAlumno = lstAlumno;
        }
        public FrmAltaGenerica(bool cambio, string valor) : this ()
        {
            this.cambioADocente = cambio;
            this.valorHora = valor;
        }
        
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            //Tiene que borrar los campos que no son compartidos
            if (cambioADocente)
            {
                
            }
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if(txtNombreAlumno.Text == "" | txtApellidoAlumno.Text =="" | txtDniAlumno.Text ==""|txtLegajo.Text =="" | txtResponsable.Text == "")
            {
                MessageBox.Show("Error Complete todos los datos");
            }
            else
            {
                //this.lstAlumno = (new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, int.Parse(txtDniAlumno.Text), true, float.Parse(cmbPrecioCuota.Text),enum.parse(EColores,"")));
                this.lstAlumno.Add(new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, int.Parse(txtDniAlumno.Text), true, float.Parse(cmbPrecioCuota.Text)));
                MessageBox.Show("Se cargo un alumno Correctamente");
                this.Hide();
            }
        }
    }
}
