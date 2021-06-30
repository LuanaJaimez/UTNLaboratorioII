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
    public partial class FrmDinero : Form
    {
        private List<Docente> listDocentes;
        private List<Administrativo> listNoDocentes;
        private List<Alumno> listAlumnosSinAula;
        private List<Alumno> listAlumnosConAula;

        double acumuladorDocente = 0;
        double acumuladorNoDocente = 0;
        float acumularoAlumnos = 0;
        float acumularoAlumnos2 = 0;

        public FrmDinero()
        {
            InitializeComponent();
        }

        public List<Docente> ListDocentes
        {
            get { return this.listDocentes; }
            set { this.listDocentes = value; }
        }
        public void CargarSueldoDocentes()
        {
            foreach (Docente item in listDocentes)
            {
                acumuladorDocente += item.Salario;
            }
            Lb_SueldoTotal.Text = acumuladorDocente.ToString();
            Lb_texto.Text = "Salario total de docentes: ";
            this.Text = "Salario de Docentes";
        }

        public List<Administrativo> ListNoDocentes
        {
            get { return this.listNoDocentes; }
            set { this.listNoDocentes = value; }
        }
        public void CargarSueldoNoDocentes()
        {
            foreach (Administrativo item in listNoDocentes)
            {
                acumuladorNoDocente += item.Salario;
            }
            Lb_SueldoTotal.Text = acumuladorNoDocente.ToString();
            Lb_texto.Text = "Salario total de Administrativos: ";
            this.Text = "Salario de Administrativos";
        }

        public List<Alumno> ListAlumnoSinAula
        {
            get { return this.listAlumnosSinAula; }
            set { this.listAlumnosSinAula = value; }
        }
        public List<Alumno> ListAlumnoConAula
        {
            get { return this.listAlumnosConAula; }
            set { this.listAlumnosConAula = value; }
        }
        public void CargarRecaudacionTotal()
        {
            foreach (Alumno item in listAlumnosSinAula)
            {
                acumularoAlumnos += item.PrecioCuota;
            }

            foreach (Alumno item in listAlumnosConAula)
            {
                acumularoAlumnos2 = (acumularoAlumnos2 + item.PrecioCuota);
            }
            Lb_texto.Text = "Recaudacion total del Jardin";
            Lb_SueldoTotal.Text = (acumularoAlumnos + acumularoAlumnos2).ToString();
            this.Text = "Recaudacion";
        }



    }//
}//
