using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FormularioJardin;

namespace FormularioDocente
{
    public partial class FrmArchivoTexto : Form
    {
        private const bool V = true;
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        List<Responsable> listaResponsable;

        string erroresAGuardar;

        public List<Docente> ListaDocentes
        {
            get { return this.listaDocentes; }
            set { listaDocentes = value; }
        }
        public List<Alumno> ListaAlumnos
        {
            get { return this.listaAlumnos; }
            set { listaAlumnos = value; }
        }

        public List<Responsable> ListaResponsable
        {
            get { return this.listaResponsable; }
            set { listaResponsable = value; }
        }
        public FrmArchivoTexto()
        {
            InitializeComponent();
        }
        public FrmArchivoTexto(string men):this()
        {
            this.erroresAGuardar = men;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] DescripcionesDeArchivos = new string[] { "Archivos de Texto", "Imagenes" };
            string[] ExtencionesDeArchivos = new string[] { "txt", "jpg" };
            string NombreDelArchivo = "";

            string Filtro = "";
            //Agrego los filtros de selección de archivos
            for (int I = 0; I < DescripcionesDeArchivos.Length && I < ExtencionesDeArchivos.Length; I++)
                Filtro += DescripcionesDeArchivos[I] + " (*." + ExtencionesDeArchivos[I] + ")|*." + ExtencionesDeArchivos[I] + "|";
            //Agrego filtro para todos los archivos
            Filtro += "Todos los archivos (*.*)|*.*";
            //Cargo los filtros en el objeto
            ofdAbrir.Filter = Filtro;
            //Configuraciones restantes
            ofdAbrir.AddExtension = true;
            ofdAbrir.FilterIndex = 1;
            ofdAbrir.RestoreDirectory = true;
            ofdAbrir.FileName = NombreDelArchivo;

            //Si no cancelé
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdAbrir.FileName;
                btnBuscar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                txtPath.Text = "";
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void rtxtContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarCont_Click(object sender, EventArgs e)
        {
            try
            {
                //Genero el stream
                FileStream Fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
                StreamReader Sr = new StreamReader(Fs);
                //Leo todo el archivo
                string Arch = Sr.ReadToEnd();
                //Cierro el archivo
                Sr.Close();
                Fs.Close();

                rtxtContenido.Text = Arch;
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {                               //si le pongo false, pisa todo el contenido, si le pongo true NO
                using (StreamWriter sw = new StreamWriter("C:\\Users\\frann\\Desktop\\2do-ParcialFranciscoNava\\Entidades", true))
                {
                    sw.WriteLine(erroresAGuardar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            //FrmSerializable ser = new FrmSerializable(erroresAGuardar);
            //try
            //{
            //    #region BasuraQuePuedeServir
            //    // Busco el Path de una carpeta de sistema
            //    //string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //    //string[] partes = txtPath.Text.Split(Path.DirectorySeparatorChar);
            //    //string file = partes[partes.Length - 1];

            //    //string filePath = folder + Path.DirectorySeparatorChar + file;


            //    //FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //    //
            //    //StreamWriter sw = new StreamWriter(fs);

            //    //sw.Write(rtxtContenido.Text);

            //    //sw.Close();
            //    //fs.Close();
            //    // 

            //    //using (StreamWriter sw = new StreamWriter(fs))
            //    //{
            //    //    sw.Write(rtxtContenido.Text);
            //    //}
            //    #endregion
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(saveFileDialog1.FileName))
            //        {
            //            //string txt = saveFileDialog1.FileName;
            //            //string txt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //            //StreamWriter textoAGuardar = File.CreateText(txt);
            //            ////StreamWriter textoAGuardar = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            //            //textoAGuardar.Write(rtxtContenido.Text);
            //            //textoAGuardar.Flush();
            //            //textoAGuardar.Close();

            //            //StreamWriter textoAGuardar = File.CreateText(txt);

            //            StreamWriter textoAGuardar = new StreamWriter(erroresAGuardar, true);

            //            //StreamWriter textoAGuardar = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            //            textoAGuardar.Write(erroresAGuardar);
            //            textoAGuardar.Flush();
            //            textoAGuardar.Close();

            //            //txtPath.Text = erroresAGuardar;
            //        }
            //        else
            //        {
            //            //string txt = saveFileDialog1.FileName;
            //            string txt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //            StreamWriter textoAGuardar = File.CreateText(txt);
            //            textoAGuardar.Write(erroresAGuardar);
            //            textoAGuardar.Flush();
            //            textoAGuardar.Close();

            //            txtPath.Text = txt;
            //        }
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
        }


        public void Log(string mensaje)
        {
            erroresAGuardar = mensaje;
        }
        private void FrmDeserializar_Load(object sender, EventArgs e)
        {

            //#region Docentes
            ////Creo docentes en una lista



            ////ListaDocentes = new List<Docente>();
            ////ListaDocentes.Add(new Docente("Jose", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            ////ListaDocentes.Add(new Docente("Julia", "Venecia", 7123658, true, Convert.ToDateTime("2/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            ////ListaDocentes.Add(new Docente("Elvira", "Alvez", 21458712, true, Convert.ToDateTime("3/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            ////ListaDocentes.Add(new Docente("Marta", "Rodri", 11245856, false, Convert.ToDateTime("4/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            ////ListaDocentes.Add(new Docente("Carlos", "Teki", 12458965, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            ////ListaDocentes.Add(new Docente("Walter", "Navaeki", 00009999, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200));
            //#endregion

            //#region No docentes
            ////Creo NO docentes en una lista
            ////List<Administrativo> noDocents = new List<Administrativo>();
            //////Tesorero y director
            ////noDocents.Add(new Administrativo("Jose", "tako", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Tesorería, 240));
            //////Secretaria
            ////noDocents.Add(new Administrativo("Julio", "Paso", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Dirección, 180));
            ////noDocents.Add(new Administrativo("Pablo", "Lola", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Secretaría, 140));
            ////noDocents.Add(new Administrativo("Jesus", "Pepo", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Secretaría, 140));
            //////Cocina
            ////noDocents.Add(new Administrativo("Alberto", "Rodro", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
            ////noDocents.Add(new Administrativo("Hector", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
            ////noDocents.Add(new Administrativo("Mirta", "Pupo", 2145786, true, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Cocina, 110));
            //////Porteros son tres
            ////noDocents.Add(new Administrativo("Pedro", "Flores", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
            ////noDocents.Add(new Administrativo("Dora", "Mendez", 2145786, true, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
            ////noDocents.Add(new Administrativo("Picapiedra", "Kokito", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), ECargo.Portería, 100));
            //#endregion

            //#region Alumnos
            ////Creo alumnos en una lista

            //if (listaAlumnos == null)
            //{
            //    ListaAlumnos = new List<Alumno>();
            //}

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



            ////LIsta de Responsable
            //#region Lista Responsable
            //List<Responsable> listaResposable = new List<Responsable>();
            //listaResposable.Add(new Responsable("Jose", "Vergara", 1236546, false, EParentesco.Padre, "12548121"));
            //listaResposable.Add(new Responsable("Juan", "queda", 1465514, false, EParentesco.Abuelo, "2543684"));
            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Perla", "vazquez", 564653213, true, EParentesco.Tia, "2365487"));
            //listaResposable.Add(new Responsable("caterine", "Nava", 1365461, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("jazmin", "Holguin", 25654124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("rocio", "vergaara", 14565614, true, EParentesco.Madre, "14551454"));

            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));

            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Pedro", "vazquez", 235646, false, EParentesco.Tio, "2365487"));
            //listaResposable.Add(new Responsable("Brisa", "Pereira", 1236546, true, EParentesco.Tia, "12548121"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //listaResposable.Add(new Responsable("Tamara", "Acosta", 36254124, true, EParentesco.Otro, "321451"));
            //listaResposable.Add(new Responsable("Agustina", "Sanchez", 3214514, true, EParentesco.Madre, "14551454"));
            //#endregion

            //int valor = 0;
            //foreach (var item in listaAlumnos)
            //{

            //    item.Responsable = listaResposable[valor];
            //    listaResposable[valor] = item;
            //    valor += 1;
            //}

            //#endregion

            //MessageBox.Show("Se crearon Alumnos Y Responsables por defecto");
            //MessageBox.Show(@"Se crearon " + listaDocentes.Count + " docentes, " + noDocents.Count + " no docentes y " + listaAlumnos.Count + " alumnos por defecto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
