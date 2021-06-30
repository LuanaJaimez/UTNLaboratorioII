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
using System.Xml;
using System.Xml.Serialization;
using ConexionBD;
using Entidades;
using MisExcepciones;


namespace FormularioDocente
{
    public partial class FrmSerializable : Form 
    {
        SqlConnection cl;
        SqlCommand sm;
        //Dictionary<decimal, string> provincia;
        List<KeyValuePair<decimal, string>> alumnos; // keyvaluepais clase, 
        //List<Localidad> localidades;
        List<Docente> listaDocente;
        List<Docente> listaDocenteDeserializada;

        List<Docente> listaDocentes;
        List<Alumnos> listaAlumnos;
        List<Responsable> listaResponsable;

        string erroresAGuardar;

        Thread hilo;
        Thread hilo2;

        private string nombre;
        private string apellido;
        private string sexo;
        private int edad;
        private string email;
        private int dni;
        private string direccion;


        public List<Docente> ListaDocentes
        {
            get { return this.listaDocentes; }
            set { listaDocentes = value; }
        }
        public List<Alumnos> ListaAlumnos
        {
            get { return this.listaAlumnos; }
            set { listaAlumnos = value; }
        }

        public List<Responsable> ListaResponsable
        {
            get { return this.listaResponsable; }
            set { listaResponsable = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        

        public FrmSerializable()
        {
            InitializeComponent();
            listaDocente = new List<Docente>();
            //listaDocenteDeserializada = new List<Docente>();
            alumnos = new List<KeyValuePair<decimal, string>>();
            cl = new SqlConnection();
            cl.ConnectionString = @"Data Source = FRANCISCO\SQLEXPRESS ; Initial Catalog = JardinUtn;Integrated Security=True";
            sm = new SqlCommand();
            hilo = new Thread(new ParameterizedThreadStart(MostrarTiempo));
            CheckForIllegalCrossThreadCalls = false;
            
        }

        public FrmSerializable(string men)
        {
            this.erroresAGuardar = men;
        }
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            //Docente docen = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), int.Parse(txtDni.Text), txtDireccion.Text, int.Parse(txtId.Text), txtSexo.Text, txtEmail.Text);
            SerializacionXML.Serializar(listaDocente, "docente.xml");
        }
        private void btnGuardarArchivoTexto_Click(object sender, EventArgs e)
        {
            FrmArchivoTexto des = new FrmArchivoTexto();
            des.Show();
        }
        private void btnDeserializar_Click(object sender, EventArgs e)
        {

            List<Docente> aux = new List<Docente>();
            aux = (List<Docente>)SerializacionXML.Deserializar<List<Docente>>("Docentes.xml");
            listaDocenteDeserializada = aux;
        }
        private void LLamarAlumnos()
        {
            FrmLlamaAlumno al = new FrmLlamaAlumno(listaAlumnos, listaDocenteDeserializada);
            al.Show();
            this.Hide();
            


        }
        private void MostrarTiempo(object utcObj)
        {
            //int utc = (int)utcObj;
            int utc = -3;
            while (true)
            {
                if (lblTiempo.InvokeRequired)
                {
                    lblTiempo.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblTiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("HH:mm");
                    });
                }
                else
                {
                }
                Thread.Sleep(1000);

            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            txtEdad.Text = "";
            txtEmail.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";

        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            Docente docen = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), int.Parse(txtDni.Text), txtDireccion.Text, int.Parse(txtId.Text), txtSexo.Text, txtEmail.Text);
            listaDocente.Add(docen);
            MessageBox.Show("Se agrego un docente correctamente");
        }

        private void cmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmSerializable_Load(object sender, EventArgs e)
        {
            hilo.Start(this.lblTiempo);
            

                #region Docentes
                //Creo docentes en una lista



                //ListaDocentes = new List<Docente>();
                //ListaDocentes.Add(new Docente("Jose", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                //ListaDocentes.Add(new Docente("Julia", "Venecia", 7123658, true, Convert.ToDateTime("2/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                //ListaDocentes.Add(new Docente("Elvira", "Alvez", 21458712, true, Convert.ToDateTime("3/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                //ListaDocentes.Add(new Docente("Marta", "Rodri", 11245856, false, Convert.ToDateTime("4/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                //ListaDocentes.Add(new Docente("Carlos", "Teki", 12458965, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                //ListaDocentes.Add(new Docente("Walter", "Navaeki", 00009999, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
                #endregion

                #region No docentes
                //Creo NO docentes en una lista
                //List<Administrativo> noDocents = new List<Administrativo>();
                ////Tesorero y director
                //noDocents.Add(new Administrativo("Jose", "tako", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Tesorería, 240));
                ////Secretaria
                //noDocents.Add(new Administrativo("Julio", "Paso", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Dirección, 180));
                //noDocents.Add(new Administrativo("Pablo", "Lola", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Secretaría, 140));
                //noDocents.Add(new Administrativo("Jesus", "Pepo", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Secretaría, 140));
                ////Cocina
                //noDocents.Add(new Administrativo("Alberto", "Rodro", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
                //noDocents.Add(new Administrativo("Hector", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
                //noDocents.Add(new Administrativo("Mirta", "Pupo", 2145786, true, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
                ////Porteros son tres
                //noDocents.Add(new Administrativo("Pedro", "Flores", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
                //noDocents.Add(new Administrativo("Dora", "Mendez", 2145786, true, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
                //noDocents.Add(new Administrativo("Picapiedra", "Kokito", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
                #endregion

               
                //Creo alumnos en una lista

                if (listaAlumnos == null)
                {
                    ListaAlumnos = new List<Alumnos>();
                }
            ListaAlumnos.Add(new Alumnos("1CARLOS", "HERNANDEZ", 123456, 12, "jujuy 3213", "Maria Jose", (int)EGrados.Azul,1));
            ListaAlumnos.Add(new Alumnos("2JOSE", "SAEZ", 1234657, 13, "Santa fe 323", "Hernan paz", (int)EGrados.Azul,2));
            ListaAlumnos.Add(new Alumnos("3CARLOS", "ROMERO", 123654, 12, "Paezz 123", " Jose julian", (int)EGrados.Azul,3));
            //ListaAlumnos.Add(new Alumnos("4PILAR", "RUBIO", 1234561, 13, "Santiago 234", "Gabriel Hernan", (int)EGrados.Azul,4));
            //ListaAlumnos.Add(new Alumnos("5DAVID", "ALFARO", 1234562, 12, "Hernandaria 23", "Martian Paz", (int)EGrados.Azul,5));
            //ListaAlumnos.Add(new Alumnos("7ISABEL", "ORTEGA", 1234563, 12, "Viamonte 245", "Maximo Perro", (int)EGrados.Azul,6));
                                       
            //ListaAlumnos.Add(new Alumnos("8ALEJANDRO", "MORCILLO", 1234564, 13, "Peru 456", "Hector Marco", (int)EGrados.Lila,7));
            //ListaAlumnos.Add(new Alumnos("9RAFAEL", "MARIN", 1234565, 12, "Hector noya 322", "Julian Paez", (int)EGrados.Lila,8));
            //ListaAlumnos.Add(new Alumnos("10ANTONIA", "GARRIDO", 1234566, 13, "Av mazimo 345", "Norma Perez", (int)EGrados.Lila,9));
            //ListaAlumnos.Add(new Alumnos("11FRANCISCO ", "CUENCA", 1234567, 12, "av correitnes 3454", "Maria Aguirre", (int)EGrados.Lila,10));
            //ListaAlumnos.Add(new Alumnos("1DANIEL ", "GARCIA", 2345671, 14, "Santiago del estero 254", "Kevin Villalva", (int)EGrados.Lila,11));
                                       
            //ListaAlumnos.Add(new Alumnos("MANUELA ", "GOMEZ", 2345676, 13, "Av 4 453", "Juliana Jota", (int)EGrados.Naranja,12));
            //ListaAlumnos.Add(new Alumnos("JOSEFA ", "FERNANDEZ", 2345677, 14, "Av 5 565", "Hernan Perez", (int)EGrados.Naranja,13));
            //ListaAlumnos.Add(new Alumnos("RAQUEL ", "MORENO", 2345678, 13, "Av 4 467", "Sebastian Paez", (int)EGrados.Naranja,14));
            //ListaAlumnos.Add(new Alumnos("FRANCHEZCA ", "JIMENEZ", 2345679, 13, "Av 5755 ", "Julio Saenz", (int)EGrados.Naranja,15));
            //ListaAlumnos.Add(new Alumnos("TERESA ", "PEREZ", 2345670, 14, "Av 3 4533", "Elvira Karen", (int)EGrados.Naranja,16));
            //ListaAlumnos.Add(new Alumnos("FERNANDO ", "RODRIGUEZ", 4561231, 15, "Moreno 543", "Anto Bella", (int)EGrados.Naranja,17));
                                       
            //ListaAlumnos.Add(new Alumnos("JUAN CARLOS ", "NAVARRO", 4561232, 14, "Tejeror 453", "Julieta Buyatti", (int)EGrados.Roja,18));
            //ListaAlumnos.Add(new Alumnos("ANDRES ", "NAVARRETE", 4561233, 14, "Catamarca 5434", "Yanina Collazo", (int)EGrados.Roja,19));
            //ListaAlumnos.Add(new Alumnos("JOSE MANUEL ", "RUIZ", 4561234, 15, "Hector Noya 766", "Hernan Silva", (int)EGrados.Roja,20));
            //ListaAlumnos.Add(new Alumnos("RAMON ", "DIAZ", 4561235, 15, "1ro de Mayo 4535", "Joel Gomez", (int)EGrados.Roja,21));
            //ListaAlumnos.Add(new Alumnos("BEATRIZ ", "SERRANO", 4561236, 15, "25 de Septiembre 5656", "Alejo Alegre", (int)EGrados.Roja,22));
                                       
            //ListaAlumnos.Add(new Alumnos("PAULA ", "HERNANDEZ", 4561237, 14, "Hulis 643", "Veronica Getti", (int)EGrados.Rosa,23));
            //ListaAlumnos.Add(new Alumnos("ANGELA ", "MUÑOZ", 4561238, 14, "Iberluce 46", "Guada Cano", (int)EGrados.Rosa,24));
            //ListaAlumnos.Add(new Alumnos("JULIA ", "SAEZ", 4561239, 14, "Del valle 456", "Lidia Perez", (int)EGrados.Rosa,25));
            //ListaAlumnos.Add(new Alumnos("ROCIO ", "ROMERO", 45612310, 15, "Aristobulo 234", "Alan Martinez", (int)EGrados.Rosa,26));
                                       
            //ListaAlumnos.Add(new Alumnos("2PABLO ", "MARTINEZ", 2345672, 13, "San martin 343", "Pablo Escudero", (int)EGrados.Verde,27));
            //ListaAlumnos.Add(new Alumnos("3JUAN ANTONIO ", "LOPEZ", 2345673, 14, "Av  3", "Horario Paz", (int)EGrados.Verde,28));
            //ListaAlumnos.Add(new Alumnos("4JOAQUIN ", "SANCHEZ", 2345674, 14, "Av 4 5654", " Camila Storto ", (int)EGrados.Verde,29));
            //ListaAlumnos.Add(new Alumnos("5SERGIO ", "GONZALEZ", 2345675, 13, "Av 4 4543", "Karen Paz", (int)EGrados.Verde,30));

            #region Alumnos y Responsables
            //ListaAlumnos.Add(new Alumno("1 bbbbCARLOS", "HERNANDEZ", 2415142, false, 3000));
            //ListaAlumnos.Add(new Alumno("2JOSE", "SAEZ", 364121, false, 3000));
            //ListaAlumnos.Add(new Alumno("3CARLOS", "ROMERO", 4567586, false, 3000));
            //ListaAlumnos.Add(new Alumno("4PILAR", "RUBIO", 4534531, true, 3000));
            //ListaAlumnos.Add(new Alumno("5DAVID", "ALFARO", 1230789, false, 3000));
            //ListaAlumnos.Add(new Alumno("7ISABEL", "ORTEGA", 4564786, true, 3000));
            //ListaAlumnos.Add(new Alumno("8ALEJANDRO", "MORCILLO", 454312, false, 3000));
            //ListaAlumnos.Add(new Alumno("9RAFAEL", "MARIN", 65786456, false, 3000));
            //ListaAlumnos.Add(new Alumno("10ANTONIA", "GARRIDO", 4567821, true, 3000));
            //ListaAlumnos.Add(new Alumno("11FRANCISCO ", "CUENCA", 5478564, false, 3000));



            //ListaAlumnos.Add(new Alumno("1DANIEL ", "GARCIA", 234454657, false, 3000));
            //ListaAlumnos.Add(new Alumno("2PABLO ", "MARTINEZ", 435345436, false, 3000));
            //ListaAlumnos.Add(new Alumno("3JUAN ANTONIO ", "LOPEZ", 57434234, false, 3000));
            //ListaAlumnos.Add(new Alumno("4JOAQUIN ", "SANCHEZ", 1234664, false, 3000));
            //ListaAlumnos.Add(new Alumno("5SERGIO ", "GONZALEZ", 66587687, false, 3000));
            //ListaAlumnos.Add(new Alumno("MANUELA ", "GOMEZ", 43446567, true, 3000));
            //ListaAlumnos.Add(new Alumno("JOSEFA ", "FERNANDEZ", 32443645, true, 3000));
            //ListaAlumnos.Add(new Alumno("RAQUEL ", "MORENO", 2343465, true, 3000));
            //ListaAlumnos.Add(new Alumno("FRANCHEZCA ", "JIMENEZ", 234236547, true, 3000));
            //ListaAlumnos.Add(new Alumno("TERESA ", "PEREZ", 324235475, true, 3000));

            //ListaAlumnos.Add(new Alumno("FERNANDO ", "RODRIGUEZ", 32423446, false, 3000));
            //ListaAlumnos.Add(new Alumno("JUAN CARLOS ", "NAVARRO", 32435567, false, 3000));
            //ListaAlumnos.Add(new Alumno("ANDRES ", "NAVARRETE", 547856434, false, 3000));
            //ListaAlumnos.Add(new Alumno("JOSE MANUEL ", "RUIZ", 6546546, false, 3000));
            //ListaAlumnos.Add(new Alumno("RAMON ", "DIAZ", 1243354564, false, 3000));
            //ListaAlumnos.Add(new Alumno("BEATRIZ ", "SERRANO", 12354655, true, 3000));
            //ListaAlumnos.Add(new Alumno("PAULA ", "HERNANDEZ", 1235546, true, 3000));
            //ListaAlumnos.Add(new Alumno("ANGELA ", "MUÑOZ", 5775665, true, 3000));
            //ListaAlumnos.Add(new Alumno("JULIA ", "SAEZ", 23423423, true, 3000));
            //ListaAlumnos.Add(new Alumno("ROCIO ", "ROMERO", 32345435, true, 3000));

            //ListaAlumnos.Add(new Alumno("RAUL ", "RUBIO", 2342345, false, 3000));
            //ListaAlumnos.Add(new Alumno("ALBERTO ", "LOZANO", 1241564, false, 3000));
            //ListaAlumnos.Add(new Alumno("ENRIQUE ", "CASTILLO", 5478564, false, 3000));
            //ListaAlumnos.Add(new Alumno("ALVARO ", "PICAZO", 3235465, false, 3000));
            //ListaAlumnos.Add(new Alumno("EMILIO ", "CANO", 212315498, false, 3000));
            //ListaAlumnos.Add(new Alumno("JORGE ", "MARIN", 123321564, false, 3000));
            //ListaAlumnos.Add(new Alumno("ASCENSION ", "TORRES", 213489765, true, 3000));
            //ListaAlumnos.Add(new Alumno("ANDREA ", "CORCOLES", 123215951, true, 3000));
            //ListaAlumnos.Add(new Alumno("MARIA ROSARIO", "GIL", 12314165, true, 3000));
            //ListaAlumnos.Add(new Alumno("ROSA ", "CALERO", 2331254, true, 3000));

            //ListaAlumnos.Add(new Alumno("DIEGO ", "RODENAS", 2659865, false, 3000));
            //ListaAlumnos.Add(new Alumno("JORGE ", "BLAZQUEZ", 23565316, false, 3000));
            //ListaAlumnos.Add(new Alumno("ALFONSO ", "PARDO", 25665832, false, 3000));
            //ListaAlumnos.Add(new Alumno("ADRIAN ", "NUÑEZ", 46456521, false, 3000));
            //ListaAlumnos.Add(new Alumno("RUBEN ", "MOYA", 98758564, false, 3000));
            //ListaAlumnos.Add(new Alumno("ANDREA ", "ARENAS", 4216654, true, 3000));
            //ListaAlumnos.Add(new Alumno("MARIA ROSARIO ", "BALLESTEROS", 46532132, true, 3000));
            //ListaAlumnos.Add(new Alumno("MARIA LUISA ", "TEBAR", 5894654, true, 3000));
            //ListaAlumnos.Add(new Alumno("CONSUELO ", "RAMIREZ", 65643123, true, 3000));
            //ListaAlumnos.Add(new Alumno("uuuuuuuuuuuuuAMPARO ", "RODENAS", 4856213, true, 3000));



            //LIsta de Responsable
            //#region Lista Responsable
            //List<Responsable> listaResposable = new List<Responsable>();
            //    listaResposable.Add(new Responsable("Jose", "Vergara", 1236546, false, EParentesco.Padre, "12548121"));
            //    listaResposable.Add(new Responsable("Juan", "queda", 1465514, false, EParentesco.Abuelo, "2543684"));
            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Perla", "vazquez", 564653213, true, EParentesco.Tia, "2365487"));
            //    listaResposable.Add(new Responsable("caterine", "Nava", 1365461, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("jazmin", "Holguin", 25654124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("rocio", "vergaara", 14565614, true, EParentesco.Madre, "14551454"));

            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //    listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //    listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //    #endregion

            //    int valor = 0;
            //    foreach (var item in listaAlumnos)
            //    {

            //        item.Responsable = listaResposable[valor];
            //        listaResposable[valor] = item;
            //        valor += 1;
            //    }

            #endregion

            MessageBox.Show("Se crearon Alumnos por defecto");
            //MessageBox.Show(@"Se crearon " + listaDocentes.Count + " docentes, " + noDocents.Count + " no docentes y " + listaAlumnos.Count + " alumnos por defecto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);




            #region sarasa
            //XmlTextReader reader; //Objeto que leerá XML.

            //XmlSerializer ser; //Objeto que Deserializará.

            ////Se indica ubicación del archivo XML.

            //reader = new XmlTextReader("C:\\Users\\frann\\Desktop\\2do-ParcialFranciscoNava\\ArchivoADeserializar\\Docentes.xml");

            ////Se indica el tipo de objeto ha serializar.

            //ser = new XmlSerializer(typeof(Docente));

            ////Deserializa el archivo contenido en reader, lo guarda en aux.

            //aux = (Docente)ser.Deserialize(reader);

            ////Se cierra el objeto reader.

            //reader.Close();
            #endregion

            //try
            //{

            //    cl.Open();

            //    sm.Connection = cl;
            //    sm.CommandText = "select * from Alumnos";//comando query para que traiga la tabla

            //    SqlDataReader dr = sm.ExecuteReader();

            //    dr = sm.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        alumnos.Add(new KeyValuePair<decimal, string>(decimal.Parse(dr[0].ToString()), dr[1].ToString()));
            //        System.Threading.Thread.Sleep(3000);
            //        listaDocente.Add(new Docente(dr[0].ToString(), dr[1].ToString(), (int)dr[2], (int)dr[3], dr[4].ToString(), (int)dr[5], dr[6].ToString(), dr[7].ToString()));
            //    }


            //    mostramos en el combo box
            //    cmbNombres.DataSource = null;
            //    cmbNombres.DataSource = alumnos;
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{//cierro la conexion
            //    cl.Close();
            //}


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            #region Basura
            //FrmSerializable ser = new FrmSerializable(erroresAGuardar);
            //try
            //{
            //    // Busco el Path de una carpeta de sistema
            //    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    // Tomo el nombre del archivo abierto
            //    string[] partes = txtPath.Text.Split(Path.DirectorySeparatorChar);
            //    string file = partes[partes.Length - 1];
            //    // Genero el nombre del archivo con su correspondiente Path
            //    string filePath = folder + Path.DirectorySeparatorChar + file;

            //    //Genero el stream
            //    FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //    /*
            //    StreamWriter sw = new StreamWriter(fs);
            //    //Escrito todo el archivo
            //    sw.Write(rtxtContenido.Text);
            //    //Cierro el archivo
            //    sw.Close();
            //    fs.Close();
            //     */

            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.Write(rtxtContenido.Text);
            //    }
            //}
            //catch (ArgumentException aex)
            //{
            //    MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (FileNotFoundException fex)
            //{
            //    MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            #endregion
        }


        /// <summary>
        /// Este evento guardar todo el archivo serializado en la base de datos
        /// </summary>

        private void btnAgregarBD_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Docentesasd (Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) " +
                        "VALUES (@nombre,@apellido,@edad,@sexo,@dni,@direccion,@email)";
                cl.Open();
                if (listaDocenteDeserializada.Count == 0)
                {
                    MessageBox.Show("La lista se encuentra vacia");
                    cl.Close();
                }
                else
                {
                    foreach (var item in listaDocenteDeserializada)
                    {
                        SqlCommand comando = new SqlCommand(query, cl);
                        comando.Parameters.AddWithValue("@nombre", item.Nombre);
                        comando.Parameters.AddWithValue("@apellido", item.Apellido);
                        comando.Parameters.AddWithValue("@edad", item.Edad);
                        comando.Parameters.AddWithValue("@sexo", item.Sexo);
                        comando.Parameters.AddWithValue("@dni", item.Dni);
                        comando.Parameters.AddWithValue("@direccion", item.Direccion);
                        comando.Parameters.AddWithValue("@email", item.Email);
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
                Log(men);
            }
        }

        public void Log(string mensaje)
        {
            erroresAGuardar = mensaje;
        }


        private void llamoAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLlamaAlumno al = new FrmLlamaAlumno(listaAlumnos, listaDocenteDeserializada);
            al.Show();
            this.Hide();
        }

        private void deserializarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Docente> aux = new List<Docente>();
                aux = (List<Docente>)SerializacionXML.Deserializar<List<Docente>>("Docentes.xml");
                listaDocenteDeserializada = aux;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLLamaAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLlamaAlumno al = new FrmLlamaAlumno(listaAlumnos, listaDocenteDeserializada);
                al.Show();
                //this.Hide();
                //hilo2 = new Thread(LLamarAlumnos);
                //hilo2.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
