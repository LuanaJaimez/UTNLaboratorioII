using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Entindades;
using Excepciones;
using System.Threading;
using System.IO;

namespace Clifton.Manuel._2D.Parcial2
{
    delegate void EvaluarAlumno(Alumno a);
  //  delegate void LlamarEvaluacion(object o);
    delegate void LlamarProximo(object o);

    delegate void CargarEvaluado(string palabra);


    public partial class FrmPrincipal : Form
    {
        
        string pathLogs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        Thread c;
        Thread r;
        
        Random random;
        event EvaluarAlumno RealizarEvaluacion;
    //    event LlamarEvaluacion LLamarAEvaluacion;
        event LlamarProximo LLamarAlProximo;
        event CargarEvaluado EnviaraAlumno;

        SqlConnection connection;
        SqlDataReader datos;
        FrmSecundario frmDos;


        List<Thread> hilos;
        List<Alumno> alumnos;
        List<Alumno> alumnosEvaluados;
        List<Docente> docentes;
        List<Aula> aulas;
        List<Evaluacion> evaluaciones;
        List<SqlParameter> listParameters;
        List<string> observaciones;

        Alumno alumnoProximo;

        public FrmPrincipal()
        {
            InitializeComponent();
            frmDos = new FrmSecundario();
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = DESKTOP-PGQ4HMM; Initial Catalog=JardinUtn; Integrated Security=True;";

            c = new Thread(new ParameterizedThreadStart(MostrarConexion));
            r = new Thread(new ParameterizedThreadStart(MostrarRecreo));
            hilos = new List<Thread>();

            alumnos = new List<Alumno>();
            docentes = new List<Docente>();
            aulas = new List<Aula>();
            evaluaciones = new List<Evaluacion>();
            listParameters = new List<SqlParameter>();
            observaciones = new List<string>();
            random = new Random();

            
            LLamarAlProximo += proximo;
        //    LLamarAEvaluacion += evaluacion;
            RealizarEvaluacion += evaluarAlumno;

            EnviaraAlumno += frmDos.Cargar;
        }

        #region Porpiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Alumno> AlumnosEvaluados
        {
            get { return this.alumnosEvaluados; }
            set { this.alumnosEvaluados = value; }
        }
        public List<Docente> Docentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }
        public List<Aula> Aulas
        {
            get { return this.aulas; }
            set { this.aulas = value; }
        }
        public List<Evaluacion> Evaluaciones
        {
            get { return this.evaluaciones; }
            set { this.evaluaciones = value; }
        }
        public List<string> Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        #endregion

        private void proximo(object textBox)
        {
            if (Alumnos.Count > 0)
            {
              alumnoProximo = new Alumno(Alumnos[0].Nombre, Alumnos[0].Apellido, Alumnos[0].Dni, Alumnos[0].Edad, Alumnos[0].Direccion, Alumnos[0].IdAlumno, Alumnos[0].Responsable);
              BuscarAlProximo(alumnoProximo, (TextBox)textBox);
            }
            else
            {
                if (r.IsAlive)
                {
                    c.Abort();
                }
                foreach (Thread item in hilos)
                {
                    if (item.IsAlive)
                        item.Abort();
                }
                this.Lb_Recreo.Text = "TERMINARON LAS EVALUACIONES";

            }
        }

        void BuscarAlProximo(Alumno alumno, TextBox txt)
        {
            // llama al primero de la lista de alumnos
            mostrarEnForm(alumno.ToString(), txt);

            Alumnos.RemoveAt(0);

            CargarListaAlumnos();
            // Espera el tiempo

            RealizarEvaluacion(alumno);
            //LE HAGO LA EVALUCION  
            //  LLamarAEvaluacion(this.txtEnEvaluacion);

            mostrarEnForm("", txt);
            //Lanza el evento que llama al proximo
            // LLamarAlProximo(txt);
            LLamarAlProximo(this.txtProximo);
        }
        private void evaluarAlumno(Alumno alumno)
        {
                int idProfesor = random.Next(Docentes.Count);
                //si Le HAGO LA EVALUCION  
                Evaluar(alumno, Docentes[idProfesor]);
        }
        void Evaluar(Alumno al, Docente docente)
        {
            al.CargarNota();

            Thread.Sleep(3000);

            int idAula = random.Next(Aulas.Count);
            int obs = random.Next(Observaciones.Count);
            Evaluacion eva = new Evaluacion(random.Next(), al.IdAlumno, docente.IdDocente, idAula, al.NotaUno, al.NotaDos, al.NotaFinal, Observaciones[obs]);
            al.IdAula = eva.IdAula;
            GuardarEvaluacionesEnBase(eva);

            if (al.NotaFinal >= 4)
                {
                GuardarXml(al, true);
                }
                else
                {
                GuardarXml(al, false);
            }

            //INVOCAR AL EVENTEO PARA CARGAR EL ALUMNO EN SEGUNDO FORMULARIO

           

            if (!(EnviaraAlumno.GetInvocationList() is null))
                {
                    EnviaraAlumno.Invoke(al.ToString());
                }

            
        }
        private void GuardarXml(Alumno al, bool condicion)
        {
            Xml<Alumno> inst = new Xml<Alumno>();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (condicion)
            {
                path += "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\APROBADOS";

                path += $"\\{al.Apellido}_{al.Nombre}_{DateTime.Now.ToString("dd_MM_yyyy")}.xml";

                try
                {
                    inst.Guardar(path, al);
                }
                catch (GuardarLogsException)
                {
                    Texto.Guardar(pathLogs + "\\SegundoParcialUtn\\JardinUtn\\Logs.txt", $"El Archivo XML no fue encontrado. De todas maneras se creo el archivo y se guardaron los datos del Alumno {al.Nombre} {al.Apellido}");
                }
            }
            else
            {
                path += "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\DESAPROBADOS";

                path += $"\\{al.Apellido}_{al.Nombre}_{DateTime.Now.ToString("dd_MM_yyyy")}.xml";
                try
                {  
                    inst.Guardar(path, al);
                }
                catch (GuardarLogsException)
                {
                    Texto.Guardar(pathLogs + "\\SegundoParcialUtn\\JardinUtn\\Logs.txt", $"El Archivo XML no fue encontrado. De todas maneras se creo el archivo y se guardaron los datos del Alumno {al.Nombre} {al.Apellido}");
                }
            }
        }

        //private void evaluacion(object textBox)
        //{
        //    //si tiene personas pendientes, la atiende
        //    if (!(alumnoProximo is null))
        //    {
        //        BuscarAlEvaluado(alumnoProximo, (TextBox)textBox);
        //    }
        //}

        // void BuscarAlEvaluado(Alumno alumno, TextBox txt)
        //{
        //    // Muestra en el txt
        //    mostrarEnForm(alumno.ToString(), txt);
        //    // Espera el tiempo


        //        //LE HAGO LA EVALUCION  

        //        RealizarEvaluacion(alumno);

        //    mostrarEnForm("", txt);
        //    //Lanza el evento que llama al proximo
        //   // LLamarAEvaluacion(txt);
        //}

        void mostrarEnForm(string mensaje, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
                {
                    txt.Text = mensaje;
                });
            }
            else
            {
                txt.Text = mensaje;
            }
        }

        




        /*   --------------------------------------   LOAD -----------------------------------   */

        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            c.Start(this.Lb_EstadoConexion);

            LeerAlumnos();
            LeerAulas();
            LeerDocentes();

            if (Docentes.Count == 0)
            {
                LeerDocentesXml();
                GuardarDocentesEnBase();
            }
            CargarListaAlumnos();
            CargarListaObservaciones();

            frmDos.Show();
        }

        public void MostrarConexion(object utcObjeto)
        {
            Label lbConexion = (Label)utcObjeto;

            while (true)
            {
                if (lbConexion.InvokeRequired)
                {
                    lbConexion.BeginInvoke((MethodInvoker)delegate () {
                        if (SQL.Conectar(connection))
                        {
                            lbConexion.BackColor = Color.Green;
                        }
                        else
                        {
                            lbConexion.BackColor = Color.Red;
                        }
                    });
                }
                Thread.Sleep(5000);
            }
        }
        private void LeerAlumnos()
        {
            int contador = 0;
           datos = SQL.Leer(connection, "SELECT * FROM Alumnos");
            while (datos.Read())
            {                       
                 Alumnos.Add(new Alumno(datos[1].ToString(),datos[2].ToString(), (int)datos[4], (int)datos[3], datos[5].ToString(), (int)datos[0], datos[6].ToString()) );
                contador++;
            }
        //    MessageBox.Show($"Se Cargaron {contador} alumnos");
           
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void CargarListaAlumnos()
        {
            if (listAlumnos.InvokeRequired)
            {
                listAlumnos.BeginInvoke((MethodInvoker)delegate
                {
                    listAlumnos.Items.Clear();
                    foreach (Alumno item in Alumnos)
                    {
                        listAlumnos.Items.Add(item.ToString());
                    }
                });
            }
            else
            {
                listAlumnos.Items.Clear();
                foreach (Alumno item in Alumnos)
                {
                    listAlumnos.Items.Add(item.ToString());
                }
            } 
        }
        private void CargarListaObservaciones()
        {
            Observaciones.Add("Prolijo");
            Observaciones.Add("Desastroso");
            Observaciones.Add("Excelente");
            Observaciones.Add("Usted es Diabolico ");
        }

        private void LeerAulas()
        {
            int contador = 0;
            datos = SQL.Leer(connection, "SELECT * FROM Aulas");
            while (datos.Read())
            {                          
                Aulas.Add(new Aula((int)datos[0], datos[1].ToString() ));
                contador++;
            }
           // MessageBox.Show($"Se Cargaron {contador} Aulas");

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void LeerDocentes()
        {
            int contador = 0;
            datos = SQL.Leer(connection, "SELECT * FROM Docentes");
            while (datos.Read())
            {                           
                Docentes.Add(new Docente(datos[1].ToString(), datos[2].ToString(),(int)datos[5], (int)datos[3],datos[6].ToString(),(int)datos[0],datos[4].ToString(), datos[7].ToString()));
                contador++;
            }
         //   MessageBox.Show($"Se Cargaron {contador} Docentes");

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LeerEvaluaciones()
        {
            int contador = 0;
            datos = SQL.Leer(connection, "SELECT * FROM Evaluaciones");
            while (datos.Read())
            {
                Evaluaciones.Add(new Evaluacion( (int)datos[0],(int)datos[1],(int)datos[2],(int)datos[3], (int)datos[4], (int)datos[5],(int)datos[6],datos[7].ToString()));
                contador++;
            }
          //  MessageBox.Show($"Se Cargaron {contador} Evaluaciones");

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LeerDocentesXml()
        {
            // LEER EL ARCHIVO XML.. LEER EL PARCIAL PARA BUSCAR LA RUTA
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\SegundoParcialUtn\\JardinUtn\\Docentes.xml";

                try
                {
                    Xml<List<Docente>> inst = new Xml<List<Docente>>();
                    inst.Leer(path, out docentes);
                }
                catch (GuardarLogsException)
                {
                    Texto.Guardar(pathLogs + "\\SegundoParcialUtn\\JardinUtn\\Logs.txt", "El Archivo Docentes.xml no fue encontrado. No se cargaron los datos al programa");
                }

                //   MessageBox.Show("Se leyeron los docentes del XML");
        }


        private void GuardarDocentesEnBase()
        {
            int cantidad = 0;
            listParameters.Clear();

            foreach (Docente item in Docentes)
            {
                listParameters.Add(new SqlParameter("Nombre", item.Nombre));
                listParameters.Add(new SqlParameter("Apellido", item.Apellido));
                listParameters.Add(new SqlParameter("Edad", item.Edad));
                listParameters.Add(new SqlParameter("Sexo", item.Sexo));
                listParameters.Add(new SqlParameter("Dni", item.Dni));
                listParameters.Add(new SqlParameter("Direccion", item.Direccion));
                listParameters.Add(new SqlParameter("Email", item.Email));

                cantidad += SQL.Guardar(connection, listParameters, "INSERT INTO [Docentes] (Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) VALUES (@Nombre,@Apellido,@Edad,@Sexo,@Dni,@Direccion,@Email)");
                listParameters.Clear();
            }
            
            //if (cantidad > 0)
            //{
            //    MessageBox.Show($"Se cargaron en la Base {cantidad} de Docentes");
            //}
            //else
            //{
            //    MessageBox.Show($"NO Guardo Docentes en Base");
            //}
        }

        int cantidadEva = 0;
        private void GuardarEvaluacionesEnBase(Evaluacion eva)
        {
            int cantidad = 0;
            listParameters.Clear();

                listParameters.Add(new SqlParameter("IdAl", eva.IdAlumno));
                listParameters.Add(new SqlParameter("IdDoc", eva.IdDocente));
                listParameters.Add(new SqlParameter("IdAula", eva.IdAula));
                listParameters.Add(new SqlParameter("NotaUno", eva.NotaUno));
                listParameters.Add(new SqlParameter("NotaDos", eva.NotaDos));
                listParameters.Add(new SqlParameter("NotaFinal", eva.NotaFinal));
                listParameters.Add(new SqlParameter("Obs", eva.Observaciones));

                cantidad = SQL.Guardar(connection, listParameters, "INSERT INTO [Evaluaciones] (idAlumno,idDocente,idAula,Nota_1,Nota_2,NotaFinal,Observaciones) VALUES (@IdAl,@IdDoc,@IdAula,@NotaUno,@NotaDos,@NotaFinal,@Obs)");
                listParameters.Clear();

            if (cantidad > 0)
            {
                if (Lb_cantEvaluados.InvokeRequired)
                {
                    Lb_cantEvaluados.BeginInvoke((MethodInvoker)delegate
                    {
                        cantidadEva += cantidad;
                        this.Lb_cantEvaluados.Text = cantidadEva.ToString();
                    });
                }
                else
                {
                    cantidadEva += cantidad;
                    this.Lb_cantEvaluados.Text = cantidadEva.ToString();
                }
            }
            else
            {
                MessageBox.Show($"NO Guardo Evaluacion en Base");
            }
        }


        public void MostrarRecreo(object utcObjeto)
        {
            Label lbMensaje = (Label)utcObjeto;

            
            while (true)
            {
                Thread.Sleep(10000);
                if (lbMensaje.InvokeRequired)
                {
                    lbMensaje.BeginInvoke((MethodInvoker)delegate () {

                            lbMensaje.Text = "¡¡ RIN RIN RECREO !!";
                    });
                }
                Thread.Sleep(5000);

                if (lbMensaje.InvokeRequired)
                {
                    lbMensaje.BeginInvoke((MethodInvoker)delegate () {

                        lbMensaje.Text = String.Empty;
                    });
                }
            }
        }

       

        // REVISAR LOS ARCHIVOS XML

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_Timer.Text = DateTime.Now.ToString("hh:mm:ss");
            Lb_Fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            if (c.IsAlive)
            {
                c.Abort();
            }
            if (r.IsAlive)
            {
                c.Abort();
            }
            //Elimino los hilos si aun existen
            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            r.Start(this.Lb_Recreo);

            if (hilos.Count != 1)
            {
                hilos.Add(new Thread(new ParameterizedThreadStart(proximo)));
            }

            if (!hilos[0].IsAlive)
            {
                hilos[0] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[0].Start(this.txtProximo);
            }

            this.btnEmpezar.Click -= btnEmpezar_Click;
        }


    }//
}//
