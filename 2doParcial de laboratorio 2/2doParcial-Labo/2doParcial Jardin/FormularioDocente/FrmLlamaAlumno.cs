using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormularioDocente
{
    public partial class FrmLlamaAlumno : Form
    {
        SqlConnection cl;
        SqlCommand sm;

        List<Alumnos> listaAlumno;
        private List<Docente> listaDocente;
        Thread t;

        Alumnos notasAlum = new Alumnos();
        List<Alumnos> lstAlumConNotas = new List<Alumnos>();
        List<Evaluaciones> listaEvaluaciones = new List<Evaluaciones>();
        List<Aulas> listaAula; 

        string erroresAGuardar;
        public List<Alumnos> ListaAlumno { get => listaAlumno; set => listaAlumno = value; }
        public List<Docente> ListaDocente { get => listaDocente; set => listaDocente = value; }

        
        public FrmLlamaAlumno()
        {
            
            InitializeComponent();
            this.listaAlumno = new List<Alumnos>();
            this.ListaDocente = new List<Docente>();
            this.listaAula = new List<Aulas>();
            cl = new SqlConnection();
            cl.ConnectionString = @"Data Source = FRANCISCO\SQLEXPRESS ; Initial Catalog = JardinUtn;Integrated Security=True";
            sm = new SqlCommand();
        }

        public FrmLlamaAlumno(List<Alumnos> lstAlu) :this()
        {
            this.listaAlumno = lstAlu;
        }

        public FrmLlamaAlumno(List<Alumnos> lstAlu, List<Docente> lstDocen):this(lstAlu)
        {
            this.listaDocente = lstDocen;
        }

        public void MuestroAlumno()
        {
            Random rm = new Random();
            Evaluaciones ev = new Evaluaciones();
            do
            {
                try
                {
                    int indice = rm.Next(0, listaDocente.Count - 1);

                    for (int i = 0; i < listaAlumno.Count; i++)
                    {
                        Aulas Aula = new Aulas();
                        //int count = 0;
                        int count = i;
                        //}
                        ////foreach (var item in listaAlumno)
                        //{
                        //this.AlterarLabel("Legajo: "+ item.Legajo +"Alumno: "+ item.Nombre + item.Apellido +" Lo Evalua Profesor: " + listaDocente[indice].Nombre);
                        var label1 = listaAlumno[i].Nombre + listaAlumno[i].Apellido + " Lo Evalua Profesor: " + listaDocente[indice].Nombre;
                        var label2 = listaAlumno[count + 1].Nombre + listaAlumno[count + 1].Apellido;
                        if (listaAlumno.Count == 0)
                            label2 = "";


                        this.AlterarLabel(label1);
                        this.AlterarLabel2(label2);
                        //this.AlterarLabel("Legajo: " + listaAlumno[i].Legajo + "Alumno: " + listaAlumno[i].Nombre + listaAlumno[i].Apellido + " Lo Evalua Profesor: " + listaDocente[indice].Nombre);
                        Thread.Sleep(2000);
                        //item.Legajo = ev.IdAlumno;
                        ev.IdAlumno = listaAlumno[i].IdAlumnos;
                        ev.Nota_1 = rm.Next(0, 10);
                        ev.Nota_2 = rm.Next(1, 10);
                        ev.NotaFinal = (ev.Nota_1 + ev.Nota_2) / 2;
                        //DialogResult resultado = MessageBox.Show("Su nota es: "+ev.Nota_1, "Nota de "+item.Nombre , MessageBoxButtons.OK);
                        DialogResult resultado1 = MessageBox.Show("Su Nota es: " + ev.Nota_1, "Primer Examen " + listaAlumno[i].Nombre, MessageBoxButtons.OK);
                        DialogResult resultado2 = MessageBox.Show("Su Nota es: " + ev.Nota_2, "Segundo Examen " + listaAlumno[i].Nombre, MessageBoxButtons.OK);
                        DialogResult promedio = MessageBox.Show("Su Nota Final " + ev.NotaFinal, "Nota Final " + listaAlumno[i].Nombre, MessageBoxButtons.OK);

                        


                        string pathDesaprovados = Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Desaprobados", listaAlumno[i].Apellido + "_" + listaAlumno[i].Nombre + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".xml");
                        string pathAprobados = Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados", listaAlumno[i].Apellido + "_" + listaAlumno[i].Nombre + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".xml");

                        //DirectoryInfo info = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments + File.Create(""));
                        if (ev.Nota_1 < 7)
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathDesaprovados);
                        }
                        else
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathAprobados);
                        }
                        if (ev.Nota_2 < 7)
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathDesaprovados);
                        }
                        else
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathAprobados);
                        }
                        if (ev.NotaFinal < 7)
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathDesaprovados);
                        }
                        else
                        {
                            SerializacionXML.Serializar(listaAlumno[i], pathAprobados);
                        }
                        //if (resultado == DialogResult.Yes)
                        //    MessageBox.Show("Voy a Serializar");
                        listaEvaluaciones.Add(new Evaluaciones(listaAlumno.Count + 1, listaAlumno[i].IdAlumnos, listaDocente[indice].IdDocente, Aula.IdAula,
                            ev.Nota_1, ev.Nota_2, ev.NotaFinal, "Falta Mejorar"));
                        listaAula.Add(new Aulas("", listaAlumno[i].IdAula));
                        indice = rm.Next(0, listaDocente.Count - 1);
                    }
                }
                catch (Exception ex)
                {
                    var men = "Error message: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        men = men + "Inner Exception: " + ex.InnerException.Message;
                    }
                    Log(men);
                    try
                    {                               //si le pongo false, pisa todo el contenido, si le pongo true NO
                        using (StreamWriter sw = new StreamWriter("C:\\Users\\frann\\Downloads\\Segundo-Parcial-Laboratorio-master\\Entidades\\ListaDeExcepciones.txt", true))
                        {
                            sw.WriteLine(erroresAGuardar);
                        }
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Error: " + exe.Message.ToString());
                    }
                    //MessageBox.Show(ex.Message);
                }
               
                ActualizoAlumnos();
            } while (true);

            

        }
        
        public void Log(string mensaje)
        {
            erroresAGuardar = mensaje;
        }
        
        public void ActualizoAlumnos()
        {
            try
            {
                string query = "INSERT INTO Alumnos (Nombre,Apellido,Edad,Dni,Direccion,Responsable) " +
                        "VALUES (@nombre,@apellido,@edad,@dni,@direccion,@responsable)";
                cl.Open();
                if (listaAlumno.Count == 0)
                {
                    MessageBox.Show("La lista se encuentra vacia");
                    cl.Close();
                }
                else
                {
                    foreach (var item in listaAlumno)
                    {
                        SqlCommand comando = new SqlCommand(query, cl);
                        comando.Parameters.AddWithValue("@nombre", item.Nombre);
                        comando.Parameters.AddWithValue("@apellido", item.Apellido);
                        comando.Parameters.AddWithValue("@edad", item.Edad);
                        //comando.Parameters.AddWithValue("@sexo", item.Sexo);
                        comando.Parameters.AddWithValue("@dni", item.Dni);
                        comando.Parameters.AddWithValue("@direccion", item.Direccion);
                        comando.Parameters.AddWithValue("@responsable", item.Responsable);
                        
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("insertado");
                }
            }
            catch (Exception ex)
            {

                var men = "Error message: " + ex.Message;
                if (ex.InnerException != null)
                {
                    men = men + "Inner Exception: " + ex.InnerException.Message;
                }
                //GuardarErrores(men);
                //Log(men);
            }
        }

        delegate void DelegadoParaAlterarLabel(object t);
        public void AlterarLabel(object texto)
        {
            if (this.label1.InvokeRequired)
            {
                DelegadoParaAlterarLabel aux = new DelegadoParaAlterarLabel(AlterarLabel);
                Object[] obj = new Object[] { texto };
                this.BeginInvoke(aux, obj);
            }
            else
            {
                this.label1.Text = texto.ToString();
            }
        }
        public void AlterarLabel2(object texto)
        {
            if (this.label2.InvokeRequired)
            {
                DelegadoParaAlterarLabel aux = new DelegadoParaAlterarLabel(AlterarLabel2);
                Object[] obj = new Object[] { texto };
                this.BeginInvoke(aux, obj);
            }
            else
            {
                this.label2.Text = texto.ToString();
            }
        }

        private void FrmLlamaAlumno_Load(object sender, EventArgs e)
        {

            ThreadStart ts = new ThreadStart(MuestroAlumno);
            this.t = new Thread(ts);
            
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.t.ThreadState == ThreadState.Unstarted)
            {
                this.t.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void GuardarErrores(string men)
        {
            FrmArchivoTexto archi = new FrmArchivoTexto(men);
            //this.Hide();
            archi.Show();
        }
    }
}
