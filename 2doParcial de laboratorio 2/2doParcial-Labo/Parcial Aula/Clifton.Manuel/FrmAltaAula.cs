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
using System.IO;

namespace Clifton.Manuel
{
    public partial class FrmAltaAula : Form
    {

        bool flagExistia = false;
        bool flagAceptado = false;

       private List<Docente> listDocentesDisponibles;
       //private List<Docente> listDocentesNoDisponibles;
       private List<Alumno> listAlumnosSinAula;
       private List<Alumno> listAlumnosConAula;
       private List<Aula> listAulas;

        private Aula unAula;
        public FrmAltaAula()
        {
            InitializeComponent();
            unAula = new Aula();
        }

        public List<Docente> ListDocentesDisponibles
        {
            get { return this.listDocentesDisponibles; }
            set { this.listDocentesDisponibles = value; }
        }
        //public List<Docente> ListDocentesNoDisponibles
        //{
        //    get { return this.listDocentesNoDisponibles; }
        //    set { this.listDocentesNoDisponibles = value; }
        //}

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
        public Aula UnAula
        {
            get { return this.unAula; }
            set { this.unAula = value; }
        }

        /// <summary>
        /// Carga alumnos en la lista de alumnos en sala
        /// </summary>
        private void CargarAlumnosEnSala()
        {
            string sexo = "";
            if (!(unAula.Alumnos is null))
            {
                foreach (Alumno item in unAula.Alumnos)
                {
                    if (item.Femenino)
                    {
                        sexo = "Femenino";
                    }
                    else
                    {
                        sexo = "Masculino";
                    }
                    listAlumnosEnSala.Items.Add($"{item.Nombre} {item.Apellido} {sexo}");
                }
            }
            else
            {
                MessageBox.Show("Aula vacia");
            }
        }

        /// <summary>
        /// Carga con valores los elementos que se usaran en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaAula_Load(object sender, EventArgs e)
        {

                cmbTurno.DataSource = Enum.GetNames(typeof(ETurno));

                foreach (Docente doc in listDocentesDisponibles)
                {
                    //int contador = 0;
                    //foreach (Aula aula in listAulas)
                    //{
                    //    if (aula.Turno == ETurno.Mañana && doc.Dni == aula.Docente.Dni) // esto va a cambiar cuando de de alta el aula y de click en agregar
                    //    {
                    //        contador++;
                    //    }
                    //    if (aula.Turno == ETurno.Tarde && doc.Dni == aula.Docente.Dni)
                    //    {
                    //        contador++;
                    //    }

                    //}
                    //if (contador == 2)
                    //{
                       
                    ////listDocentesNoDisponibles.Add(doc);
                    //}
                cmbDocetes.Items.Add($"{doc.Nombre} {doc.Apellido}");
                }



                string sexo = "";
                foreach (Alumno item in listAlumnosSinAula)
                {
                    if (item.ColorSala == EColor.SinSala)
                    {
                        if (item.Femenino)
                        {
                            sexo = "Femenino";
                        }
                        else
                        {
                            sexo = "Masculino";
                        }
                        listAlumnosSinSala.Items.Add($"{item.Nombre} {item.Apellido} {sexo}");
                    }

                }
        }




      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listAlumnosSinSala_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                listAlumnosSinSala.Items.Add(file);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listAlumnosSinSala_MouseDown(object sender, MouseEventArgs e)
        {
            if (listAlumnosSinSala.SelectedIndex != -1)
            {
                listAlumnosEnSala.DoDragDrop(listAlumnosSinSala.SelectedItem.ToString(), DragDropEffects.All);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listAlumnosEnSala_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            if (flagAceptado)
            {
              if (!(listAlumnosEnSala.Items.Contains(listAlumnosSinSala.SelectedItem)))
              {
                  if (listAlumnosEnSala.Items.Count < 30)
                  {
                      EColor color = this.CargarColor();


                      this.listAlumnosSinAula[listAlumnosSinSala.SelectedIndex].ColorSala = color;

                      if (unAula + this.listAlumnosSinAula[listAlumnosSinSala.SelectedIndex])
                      {
                          listAlumnosEnSala.Items.Add(e.Data.GetData(DataFormats.Text));
                          this.listAlumnosConAula.Add(this.listAlumnosSinAula[listAlumnosSinSala.SelectedIndex]);
                          this.listAlumnosSinAula.Remove(this.listAlumnosSinAula[listAlumnosSinSala.SelectedIndex]);
                          listAlumnosSinSala.Items.Remove(e.Data.GetData(DataFormats.Text));
                      }
                      else
                      {
                          this.listAlumnosSinAula[listAlumnosSinSala.SelectedIndex].ColorSala = EColor.SinSala;
                          MessageBox.Show("NO SE PUDO SUMAR ALUMNO");
                      }
                  }
                  else
                  {
                      MessageBox.Show("EL AULA YA TIENE NO TIENE CAPACIDAD. MAXIMO 30 ALUMNOS.");
                  }
              }
              else
              {
                  MessageBox.Show("SELECCIONA UN ALUMNO QUE NO SE ENCUENTRE EN LA SALA");
              }
            }
            else
            {
                MessageBox.Show("PRIMERO CARGA EL AULA");
            }
        }
        
        /// <summary>
        /// Crea un aula con los valores seleccionados o permite modificar un aula ya creada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarAula_Click(object sender, EventArgs e)
        {
            if (!(cmbColores.SelectedIndex == -1) && !(cmbDocetes.SelectedIndex == -1) && !(cmbTurno.SelectedIndex == -1))
            {
                EColor color = this.CargarColor();

                ETurno turno = this.CargarTurno();



                if (ValidarAulaDisponible() && ValidarTurnoDocente())
                {
                    unAula = new Aula(color, this.listDocentesDisponibles[this.cmbDocetes.SelectedIndex], turno);
                    Lb_FormAlta.Text = "Alta de Aula";
                    btnAgregar.Text = "Agregar";
                    btnAgregar.Enabled = true;
                    cmbColores.Enabled = false;
                    cmbDocetes.Enabled = false;
                    cmbTurno.Enabled = false;
                    btnAceptarAula.Enabled = false;
                    flagAceptado = true;
                }
                else if ( !ValidarAulaDisponible() )
                {
                    
                    if (MessageBox.Show("Seleccionaste un color y turno que ya existen.\nQueres Editar el Aula?", "AULA EXISTENTE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (Aula item in listAulas)
                        {
                            if (item.ColorSala == color && item.Turno == turno)
                            {
                                unAula = item;
                                unAula.Alumnos = item.Alumnos;
                                cmbDocetes.Text = $"{unAula.Docente.Nombre} {unAula.Docente.Apellido}";
                                flagExistia = true;
                                break;
                            }
                        }

                        btnAceptarAula.Enabled = false;
                        Lb_FormAlta.Text = "Editar Aula";
                        btnAgregar.Text = "Editar";
                        btnAgregar.Enabled = true;
                        cmbColores.Enabled = false;
                        cmbDocetes.Enabled = false;
                        cmbTurno.Enabled = false;
                        this.CargarAlumnosEnSala();
                        flagAceptado = true;
                    }
                    else
                    {
                        cmbColores.Text = "";
                        cmbTurno.Text = "";
                    }
                }
                        
            }
            else
            {
                MessageBox.Show("Debe seleccionar todas las opciones");
            }
        }

        /// <summary>
        /// Valida que el color y el turno este o no disponible para un Aula
        /// </summary>
        /// <returns>True si esta disponible o False si no esta disponible</returns>
        private bool ValidarAulaDisponible()
        {
            EColor color = this.CargarColor();

            ETurno turno = this.CargarTurno();

            foreach (Aula item in listAulas)
            {
                if (item.ColorSala == color && item.Turno == turno  )
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida que el doncente este disponible en el turno seleccionado
        /// </summary>
        /// <returns>True si esta disponible o False si no esta disponible</returns>
        private bool ValidarTurnoDocente()
        {
            ETurno turno = this.CargarTurno();
            foreach (Aula item in listAulas)
            {
                if((item.ColorSala == EColor.Amarillo || item.ColorSala == EColor.Naranja || item.ColorSala == EColor.Rojo || item.ColorSala == EColor.Verde) && item.Turno == turno && item.Docente.Dni == this.listDocentesDisponibles[this.cmbDocetes.SelectedIndex].Dni)
                {
                    MessageBox.Show("DOCENTE NO DISPONIBLE EN ESE TURNO");
                    cmbDocetes.Text = "";
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Carga la variable de tipo EColor segun lo seleccionado en cmbTurno
        /// </summary>
        /// <returns>ETurno</returns>
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

        /// <summary>
        /// Cambia el color de fondo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColores.Text) // esto ponerlo en el evento del cmbColor cuando elegis un color
            {
                case "Naranja":
                    this.BackColor = Color.Orange;
                    break;
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Amarillo":
                    this.BackColor = Color.Yellow;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Agrega un aula nueva o modifica un aula existente a la lista de aulas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (flagExistia)
            {
                for (int i = 0; i < listAulas.Count; i++)
                {
                    if (listAulas[i] == unAula)
                    {
                        listAulas[i] = unAula;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                listAulas.Add(unAula);
                this.DialogResult = DialogResult.OK;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Cirra el formulario modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }//
}//
