using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioJardin
{
    public partial class AltaAula : Form
    {
        List<Docente> lstDocentes;
        List<Alumno> lstAlumnos;
        List<Aula> lstAulaAmarillo;
        List<Aula> lstAulaVerde;
        List<Aula> lstAulaRojo;
        List<Aula> lstAulaNaranja;

        EColores colorSala;
        ETurno jornada;
        Docente unDocente;

        public List<Aula> LstAulaAmarillo
        {
            get { return this.lstAulaAmarillo; }
            set { lstAulaAmarillo = value; }
        }
        public AltaAula()
        {
            this.lstAulaAmarillo = new List<Aula>();
            InitializeComponent();
        }

        public AltaAula(List<Docente> lstDocentes, List<Alumno> lstAlumno) : this()
        {
            this.lstDocentes = lstDocentes;
            this.lstAlumnos = lstAlumno;

        }
        private void AltaAula_Load(object sender, EventArgs e)
        {
            //Obtengo los valores de EColores y lo asigno al cmbColor
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));


            if (!(this.lstAlumnos is null))
                foreach (var item in this.lstAlumnos)
                {
                    lstBoxAlumSinAula.Items.Add(item.Nombre + " " + item.Apellido);
                }


            if (!(this.lstDocentes is null))
                //foreach (var item in this.lstDocentes)
                //{
                //    cmbProfesor.Items.Add(item.Nombre + " " + item.Apellido);

                //}
                this.cmbProfesor.DataSource = this.lstDocentes;
            this.cmbProfesor.DisplayMember = "Nombre";
            this.cmbProfesor.ValueMember = "Dni";
            //this.cmbProfesorlistBox1
            //this.listBox1.DataSource = alumnos;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TODO: Hacer switch
            if (this.cmbColor.Text == "Amarillo")
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.cmbColor.Text == "Naranja")
            {
                this.BackColor = Color.Orange;
            }
            else if (this.cmbColor.Text == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (this.cmbColor.Text == "Verde")
            {
                this.BackColor = Color.Green;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Puse sonido
            SystemSounds.Hand.Play();

            if (this.cmbColor.SelectedItem == null || this.cmbProfesor.SelectedItem == null || this.cmbTurno.SelectedItem == null)
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {
                //Me da de alta pero de a un aula, Sino tira excepcion
                if (cmbColor.Text == "Amarillo")
                {
                    this.colorSala = (EColores)cmbColor.SelectedItem;
                    this.unDocente = (Docente)cmbProfesor.SelectedItem;
                    this.jornada = (ETurno)cmbTurno.SelectedItem;
                    //Alumno alumno = ls
                    if (!(this.lstAulaAmarillo is null))
                        this.lstAulaAmarillo.Add(new Aula(this.colorSala, this.jornada, this.unDocente));
                    //lstBoxAlumSinAula.Items.Remove()
                    //foreach (var item in this.lstAlumnos)
                    //{
                    //    lstBoxAlumSinAula.Items.Add(item.Nombre + " " + item.Apellido);
                    //}
                    MessageBox.Show("Se guardaron correctamente los cambios");
                    this.Close();
                }
                else
                {
                    //Me da de alta pero de a un aula, Sino tira excepcion
                    if (cmbColor.Text == "Verde")
                    {
                        this.colorSala = (EColores)cmbColor.SelectedItem;
                        this.unDocente = (Docente)cmbProfesor.SelectedItem;
                        this.jornada = (ETurno)cmbTurno.SelectedItem;
                        //Alumno alumno = ls
                        if (!(this.lstAulaVerde is null))
                            this.lstAulaVerde.Add(new Aula(this.colorSala, this.jornada, this.unDocente));


                        //lstBoxAlumSinAula.Items.Remove()
                        //foreach (var item in this.lstAlumnos)
                        //{
                        //    lstBoxAlumSinAula.Items.Add(item.Nombre + " " + item.Apellido);
                        //}
                        MessageBox.Show("Se guardaron correctamente los cambios");
                        this.Close();
                    }

                    else
                    {

                        //Me da de alta pero de a un aula, Sino tira excepcion
                        if (cmbColor.Text == "Rojo")
                        {
                            this.colorSala = (EColores)cmbColor.SelectedItem;
                            this.unDocente = (Docente)cmbProfesor.SelectedItem;
                            this.jornada = (ETurno)cmbTurno.SelectedItem;
                            //Alumno alumno = ls
                            if (!(this.lstAulaRojo is null))
                                this.lstAulaRojo.Add(new Aula(this.colorSala, this.jornada, this.unDocente));


                            //lstBoxAlumSinAula.Items.Remove()
                            //foreach (var item in this.lstAlumnos)
                            //{
                            //    lstBoxAlumSinAula.Items.Add(item.Nombre + " " + item.Apellido);
                            //}
                            MessageBox.Show("Se guardaron correctamente los cambios");
                            this.Close();

                            //FALTA AZUL
                        }
                    }
                    #region MyRegion
                    //var color3 = this.cmbColor.SelectedItem;

                    //var profe = this.cmbProfesor.SelectedItem;
                    ////TODO Modificar
                    ////Docente docente = this.lstDocentes.Where(x => x.Dni == (int)profe).SingleOrDefault();
                    //var turno = this.cmbTurno.SelectedItem;

                    //var listaAlu = this.lstBoxAlumSinAula.SelectedItem;

                    ////var color = EColores.Amarillo;
                    ////Docente docAux = new Docente("Jose", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);

                    ////Aula aula = new Aula(EColores.Amarillo, ETurno.Mañana, (Docente)profe);

                    //lstAulaAmarillo.Add(new Aula( color3, ETurno.Mañana, (Docente)profe));

                    ////var alumnos = this.listBox2.Items;
                    //foreach (var item in this.lstAlumnos)
                    //{
                    //    var i = (Alumno)item;
                    //    i.ColorSala = EColores.Amarillo;
                    //}

                    #endregion
                }
            }
        }
        
        private void btmPasoAAlula_Click(object sender, EventArgs e)
        {
            //agrego de la listbox de sin aula los alumnos seleccionados y los mando a los que tienen aula
            lstboxAlumConAula.Items.Add(lstBoxAlumSinAula.SelectedItem);
            lstBoxAlumSinAula.Items.RemoveAt(lstBoxAlumSinAula.SelectedIndex);
        }

        private void btnPasoASinAula_Click(object sender, EventArgs e)
        {
            lstBoxAlumSinAula.Items.Add(lstboxAlumConAula.SelectedItem);
            lstboxAlumConAula.Items.RemoveAt(lstboxAlumConAula.SelectedIndex);
        }
    }
}
