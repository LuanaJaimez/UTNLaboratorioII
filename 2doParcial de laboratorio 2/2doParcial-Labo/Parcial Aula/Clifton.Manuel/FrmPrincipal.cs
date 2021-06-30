using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Entidades;

namespace Clifton.Manuel
{
    public partial class FrmPrincipal : Form
    {
        
        string Path = @"C:\Users\manu_\Desktop\Parcial_Laboratorio2\Parcial 1 Laboratorio  2\Clifton.Manuel\bin\Debug";

        //Forms Hijos del Principal
        FrmDocente instDocentes;
        FrmAlumnos instAlumnos;
        FrmResponsables instResponsables;
        FrmNoDocente instNoDocente;
        FrmAula instAula;

        //Forms Modal
        FrmAlumnosPorAula instAlumnosPorAula;
        FrmListadoPadres instListadoPadres;
        FrmDinero instDinero;
        FrmMediaPlayer intMediaPlayer;

        //Forms Altas
        FrmAltaAlumno instAltaAlumno; 
        FrmAltaAula instAltaAula;
        FrmAltaPersonal instAlta;
        
        //Frm Bajas
        FrmBaja instBaja;
        FrmBajaAula instBajaAula;

        //Frm Modificar
        FrmEditarAlumno instEditarAlumno;
        FrmEditarResponsable instEditarResponsable;
        FrmEditarAdministrativo instEditarAdministrativo;
        


        List<Docente> docentes;
        //List<Docente> docentesNoDisponibles;

        List<Administrativo> noDocentes;

        List<Alumno> alumnosSinAula;
        List<Alumno> alumnosConAula;

        List<Responsable> responsables;

        List<Aula> aulas;

        int legajo = 1000;

        public FrmPrincipal()
        {
            InitializeComponent();
            
            docentes = new List<Docente>();
            //docentesNoDisponibles = new List<Docente>();
            noDocentes = new List<Administrativo>();
            responsables = new List<Responsable>();
            alumnosSinAula = new List<Alumno>();
            alumnosConAula = new List<Alumno>();
            aulas = new List<Aula>();
           //harcodear();
        }

        public List<Docente> Docentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }
        //public List<Docente> DocentesNoDisponibles
        //{
        //    get { return this.docentesNoDisponibles; }
        //    set { this.docentesNoDisponibles = value; }
        //}

        public List<Administrativo> NoDocentes
        {
            get { return this.noDocentes; }
            set { this.noDocentes = value; }
        }

        public List<Alumno> AlumnosSinAula
        {
            get { return this.alumnosSinAula; }
            set { this.alumnosSinAula = value; }
        }
        public List<Alumno> AlumnosConAula
        {
            get { return this.alumnosConAula; }
            set { this.alumnosConAula = value; }
        }
        public List<Aula> Aulas
        {
            get { return this.aulas; }
            set { this.aulas = value; }
        }

        public List<Responsable> Responsables
        {
            get { return this.responsables; }
            set { this.responsables = value; }
        }

        //metodo para mostrar forms hijos en los paneles 1 y 2
        #region frmHijos
        public void AbrirFormHijo(object formHijo)
        {
            if (this.panelContenedor1.Controls.Count > 0)
            {
                this.panelContenedor1.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor1.Controls.Add(fh);
            this.panelContenedor1.Tag = fh;
            fh.Show();
        }


        public void AbrirFormHijo2(object formHijo)
        {
            if (this.panelContenedor2.Controls.Count > 0)
            {
                this.panelContenedor2.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor2.Controls.Add(fh);
            this.panelContenedor2.Tag = fh;
            fh.Show();
        }
        #endregion


        //Harcodeo
        #region Harcodeo
        //public void harcodear()
        //{
        //    // string Direccion = @"C:\Users\manu_\Desktop\Parcial_Laboratorio2\Parcial 1 Laboratorio  2\Clifton.Manuel\bin\Debug";

        //    //Docentes
        //    docentes.Add(new Docente("Carlos", "Monzon", 25147896, false, Convert.ToDateTime("1/2/2000 11:30:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250));
        //    docentes.Add(new Docente("Pepe", "Argento", 352478899, false, Convert.ToDateTime("1/2/2000 7:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250));
        //    docentes.Add(new Docente("Lucia", "Gonzalez", 425896377, true, Convert.ToDateTime("1/2/2000 8:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250));
        //    docentes.Add(new Docente("Ana", "Lopez", 547286785, true, Convert.ToDateTime("1/2/2000 12:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250));
        //    docentes.Add(new Docente("Manuel", "Clifton", 68422398, false, Convert.ToDateTime("1/2/2000 9:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250));

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Docentes.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Docente>)));

        //        ser.Serialize(Escribir, Docentes);
        //    }

        //    //No Docente
        //    noDocentes.Add(new Administrativo("Maria", "Gonzalez", 25123456, true, Convert.ToDateTime("1/2/2000 07:00:00 AM"), Convert.ToDateTime("20:00:00"), ECargo.Cocina));
        //    noDocentes.Add(new Administrativo("Juan Carlos", "Lopez", 25123456, false, Convert.ToDateTime("1/2/2000 07:00:00 AM"), Convert.ToDateTime("20:00:00"), ECargo.Cocina));
        //    noDocentes.Add(new Administrativo("Lucas", "Del Rio", 25123456, false, Convert.ToDateTime("1/2/2000 07:00:00 AM"), Convert.ToDateTime("20:00:00"), ECargo.Cocina));
        //    noDocentes.Add(new Administrativo("Esteban", "Quito", 25123456, false, Convert.ToDateTime("1/2/2000 06:00:00 AM"), Convert.ToDateTime("14:00:00"), ECargo.Portería));
        //    noDocentes.Add(new Administrativo("Firulais", "Aquino", 25123456, false, Convert.ToDateTime("1/2/2000 13:00:00 PM"), Convert.ToDateTime("22:00:00"), ECargo.Portería));
        //    noDocentes.Add(new Administrativo("Sebastian", "Perkins", 25123456, false, Convert.ToDateTime("1/2/2000 08:00:00 AM"), Convert.ToDateTime("17:00:00"), ECargo.Tesorería));
        //    noDocentes.Add(new Administrativo("Romina", "Ayala", 25123456, true, Convert.ToDateTime("1/2/2000 09:00:00 AM"), Convert.ToDateTime("15:00:00"), ECargo.Sexretaría));
        //    noDocentes.Add(new Administrativo("Ailen", "Miño", 25123456, true, Convert.ToDateTime("1/2/2000 09:00:00 AM"), Convert.ToDateTime("14:00:00"), ECargo.Dirección));
        //    noDocentes.Add(new Administrativo("Luicina", "Lemarchan", 25123456, true, Convert.ToDateTime("1/2/2000 09:00:00 AM"), Convert.ToDateTime("15:00:00"), ECargo.Sexretaría));
        //    noDocentes.Add(new Administrativo("Pedro", "Escamoso", 25123456, true, Convert.ToDateTime("1/2/2000 09:00:00 AM"), Convert.ToDateTime("17:00:00"), ECargo.Tesorería));

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\NoDocentes.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Administrativo>)));

        //        ser.Serialize(Escribir, NoDocentes);
        //    }

        //    //Responsable
        //    responsables.Add(new Responsable("Ferris", "Scattergood", 128130907, false, EParentesco.Abuelo, "621033210"));
        //    responsables.Add(new Responsable("Siffre", "Fitzackerley", 234695332, false, EParentesco.Padre, "478 - 32 - 1377"));
        //    responsables.Add(new Responsable("Lyman", "Royse", 304835577, false, EParentesco.Madre, "307 - 32 - 0062"));
        //    responsables.Add(new Responsable("Stephie", "Bettaney", 375066200, true, EParentesco.Madre, "786 - 70 - 3651"));
        //    responsables.Add(new Responsable("Marice", "McMillam", 679352493, true, EParentesco.Abuela, "400 - 73 - 4944"));
        //    responsables.Add(new Responsable("Abe", "Tregunna", 872682296, false, EParentesco.Padre, "167-13-3949"));
        //    responsables.Add(new Responsable("Barron", "Hogbourne", 669586620, false, EParentesco.Tio, "259-18-5969"));
        //    responsables.Add(new Responsable("Nat", "Lilywhite", 572250600, true, EParentesco.Tia, "359-45-2873"));
        //    responsables.Add(new Responsable("Dwayne", "Corwin", 688550134, false, EParentesco.Padre, "393-16-8540"));
        //    responsables.Add(new Responsable("Pepe", "Argento", 128130907, false, EParentesco.Abuelo, "621033210"));//
        //    responsables.Add(new Responsable("Kristofer", "Kiffe", 358581830, true, EParentesco.Madre, "300 - 72 - 0170"));
        //    responsables.Add(new Responsable("Suzanna", "Allwood", 267805786, true, EParentesco.Madre, "782 - 18 - 0313"));
        //    responsables.Add(new Responsable("Paolo", "McAllester", 863925411, false, EParentesco.Abuelo, "853 - 84 - 2757"));
        //    responsables.Add(new Responsable("Athene", "Clover", 232034718, true, EParentesco.Madre, "469 - 73 - 4369"));
        //    responsables.Add(new Responsable("Melisent", "Jubb", 290981695, true, EParentesco.Madre, "181 - 37 - 4512"));
        //    responsables.Add(new Responsable("Jobey", "Duiged", 362097891, false, EParentesco.Padre, "830 - 53 - 5429"));
        //    responsables.Add(new Responsable("Irina", "Lamers", 243636957, true, EParentesco.Tia, "808 - 48 - 8421"));
        //    responsables.Add(new Responsable("Ariana", "Peasegod", 580194214, false, EParentesco.Padre, "559 - 14 - 5232"));
        //    responsables.Add(new Responsable("Marshal", "Scattergood", 128130907, false, EParentesco.Abuelo, "1548033210"));
        //    responsables.Add(new Responsable("Quint", "Linstead", 876357534, false, EParentesco.Padre, "481 - 11 - 8419"));//
        //    responsables.Add(new Responsable("Ernesto", "Crewther", 398219682, false, EParentesco.Padre, "322 - 28 - 9613"));
        //    responsables.Add(new Responsable("Sissy", "Gajewski", 372916850, true, EParentesco.Madre, "324 - 48 - 9537"));
        //    responsables.Add(new Responsable("Eugenius", "Dignum", 614160253, false, EParentesco.Abuelo, "178 - 25 - 7788"));
        //    responsables.Add(new Responsable("Almeta", "Boyda", 863910345, true, EParentesco.Abuela, "819 - 84 - 5584"));
        //    responsables.Add(new Responsable("Tanny", "Sanbrook", 720709331, true, EParentesco.Madre, "403 - 02 - 5152"));
        //    responsables.Add(new Responsable("Kaleena", "Campey", 138790416, false, EParentesco.Abuela, "650 - 69 - 4735"));
        //    responsables.Add(new Responsable("Brandea", "Marchello", 459322099, true, EParentesco.Madre, "718 - 57 - 7460"));
        //    responsables.Add(new Responsable("Dorita", "Wickling", 877779633, true, EParentesco.Madre, "135 - 56 - 7318"));
        //    responsables.Add(new Responsable("Barn", "Cavendish", 135729340, true, EParentesco.Madre, "309 - 18 - 9297"));
        //    responsables.Add(new Responsable("Cal", "Kalvin", 651866512, false, EParentesco.Padre, "879 - 66 - 1270"));//
        //    responsables.Add(new Responsable("Nefen", "Montague", 563888214, false, EParentesco.Padre, "172 - 41 - 3190"));
        //    responsables.Add(new Responsable("Page", "Frankes", 880438844, false, EParentesco.Padre, "556 - 32 - 9558"));
        //    responsables.Add(new Responsable("Nola", "Standley", 797459804, true, EParentesco.Abuela, "413 - 67 - 6103"));
        //    responsables.Add(new Responsable("Marshal", "McGeneay", 758943894, true, EParentesco.Madre, "166-64-5885"));
        //    responsables.Add(new Responsable("Ange", "Pym", 674314822, true, EParentesco.Tia, "286-38-6206"));
        //    responsables.Add(new Responsable("Fayre", "Blas", 393176000, false, EParentesco.Madre, "314-31-4111"));
        //    responsables.Add(new Responsable("Curt", "Spatarul", 326599769, false, EParentesco.Padre, "338-86-1315"));
        //    responsables.Add(new Responsable("Marietta", "Andrault", 868608372, true, EParentesco.Madre, "224-51-2949"));
        //    responsables.Add(new Responsable("Ferris", "Scattergood", 128130907, false, EParentesco.Abuelo, "621033210"));
        //    responsables.Add(new Responsable("Gussie", "Lorman", 747485746, false, EParentesco.Tia, "480-54-1626"));//
        //    responsables.Add(new Responsable("Ashlee", "Kayes", 432251238, true, EParentesco.Abuela, "356-62-2566"));
        //    responsables.Add(new Responsable("Alix", "Jozefowicz", 607079475, false, EParentesco.Padre, "106-40-4945"));
        //    responsables.Add(new Responsable("Gabriel", "Benzing", 542581785, false, EParentesco.Padre, "297-56-8552"));
        //    responsables.Add(new Responsable("Mikey", "Saffin", 414124772, false, EParentesco.Tio, "613-53-3075"));
        //    responsables.Add(new Responsable("Catriona", "Matschoss", 575567260, true, EParentesco.Abuela, "646-15-6557"));
        //    responsables.Add(new Responsable("Abagael", "Artz", 393872065, true, EParentesco.Madre, "592-40-1719"));
        //    responsables.Add(new Responsable("Darcey", "Buchanan", 228963840, true, EParentesco.Madre, "889-85-4205"));
        //    responsables.Add(new Responsable("Madelaine", "Fincher", 470620242, false, EParentesco.Tia, "598-95-27800"));
        //    responsables.Add(new Responsable("Keeley", "Brozek", 654159876, true, EParentesco.Madre, "267-26-6064"));
        //    responsables.Add(new Responsable("Kory", "Helkin", 328201426, false, EParentesco.Abuelo, "552-04-0447"));

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Responsables.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Responsable>)));

        //        ser.Serialize(Escribir, Responsables);
        //    }

        //    //ALUMNOS
        //    alumnosSinAula.Add(new Alumno("Reeta", "Imrie", 248844921, true, 1));
        //    alumnosSinAula[0].Responsable = responsables[0];
        //    alumnosSinAula[0].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Mord", "Grimolbie", 496695006, true, 2));
        //    alumnosSinAula[1].Responsable = responsables[1];
        //    alumnosSinAula[1].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Isac", "Jeffers", 819469112, false, 3));
        //    alumnosSinAula[2].Responsable = responsables[2];
        //    alumnosSinAula[2].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Bill", "Corbally", 32057929, false, 4));
        //    alumnosSinAula[3].Responsable = responsables[3];
        //    alumnosSinAula[3].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Ileane", "Assandri", 22861674, false, 5));
        //    alumnosSinAula[4].Responsable = responsables[4];
        //    alumnosSinAula[4].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Tucker", "Van Daalen", 206331832, false, 6));
        //    alumnosSinAula[5].Responsable = responsables[5];
        //    alumnosSinAula[5].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Valene", "Blaydes", 726992380, true, 7));
        //    alumnosSinAula[6].Responsable = responsables[6];
        //    alumnosSinAula[6].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Sancho", "McGinney", 189232346, false, 8));
        //    alumnosSinAula[7].Responsable = responsables[7];
        //    alumnosSinAula[7].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Niki", "Bynold", 641560897, true, 9));
        //    alumnosSinAula[8].Responsable = responsables[8];
        //    alumnosSinAula[8].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Raf", "Waber", 676745987, false, 10));//
        //    alumnosSinAula[9].Responsable = responsables[9];
        //    alumnosSinAula[9].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Gretel", "Beslier", 332129967, false, 11));
        //    alumnosSinAula[10].Responsable = responsables[10];
        //    alumnosSinAula[10].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Katharina", "Prestland", 155306048, true, 12));
        //    alumnosSinAula[11].Responsable = responsables[11];
        //    alumnosSinAula[11].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Earl", "Philippard", 233622625, false, 13));
        //    alumnosSinAula[12].Responsable = responsables[12];
        //    alumnosSinAula[12].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Fannie", "Brambley", 539286008, false, 14));
        //    alumnosSinAula[13].Responsable = responsables[13];
        //    alumnosSinAula[13].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Walker", "Enderle", 553016801, false, 15));
        //    alumnosSinAula[14].Responsable = responsables[14];
        //    alumnosSinAula[14].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Brandi", "Warder", 118618816, false, 16));
        //    alumnosSinAula[15].Responsable = responsables[15];
        //    alumnosSinAula[15].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Percival", "Alesin", 579670425, false, 17));
        //    alumnosSinAula[16].Responsable = responsables[16];
        //    alumnosSinAula[16].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Dall", "Pourvoieur", 351411175, false, 18));
        //    alumnosSinAula[17].Responsable = responsables[17];
        //    alumnosSinAula[17].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Cathy", "Gretham", 780740129, false, 19));
        //    alumnosSinAula[18].Responsable = responsables[18];
        //    alumnosSinAula[18].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Emmalynne", "Leggat", 550478691, false, 20));//
        //    alumnosSinAula[19].Responsable = responsables[19];
        //    alumnosSinAula[19].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Fanny", "Stewartson", 554646413, false, 21));
        //    alumnosSinAula[20].Responsable = responsables[20];
        //    alumnosSinAula[20].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Celinka", "Keeling", 672543534, false, 22));
        //    alumnosSinAula[21].Responsable = responsables[21];
        //    alumnosSinAula[21].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Shaylyn", "Ewbanche", 756899588, false, 23));
        //    alumnosSinAula[22].Responsable = responsables[22];
        //    alumnosSinAula[22].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Herby", "Lillgard", 451120647, false, 24));
        //    alumnosSinAula[23].Responsable = responsables[23];
        //    alumnosSinAula[23].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Bernadine", "De Giovanni", 453278200, false, 25));
        //    alumnosSinAula[24].Responsable = responsables[24];
        //    alumnosSinAula[24].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Betta", "Silverston", 470562282, true, 26));
        //    alumnosSinAula[25].Responsable = responsables[25];
        //    alumnosSinAula[25].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Bertrando", "Lerhinan", 808638199, true, 27));
        //    alumnosSinAula[26].Responsable = responsables[26];
        //    alumnosSinAula[26].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Dare", "Drust", 190739591, false, 28));
        //    alumnosSinAula[27].Responsable = responsables[27];
        //    alumnosSinAula[27].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Alexa", "Klimochkin", 806218356, true, 29));
        //    alumnosSinAula[28].Responsable = responsables[28];
        //    alumnosSinAula[28].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Loni", "Vogeler", 177823726, false, 30));//
        //    alumnosSinAula[29].Responsable = responsables[29];
        //    alumnosSinAula[29].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Lezley", "Housden", 421134484, true, 31));
        //    alumnosSinAula[30].Responsable = responsables[30];
        //    alumnosSinAula[30].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Thomasine", "Von Oertzen", 786417423, false, 32));
        //    alumnosSinAula[31].Responsable = responsables[31];
        //    alumnosSinAula[31].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Corrine", "Rouchy", 120290888, true, 33));
        //    alumnosSinAula[32].Responsable = responsables[32];
        //    alumnosSinAula[32].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Curr", "Pountney", 294319904, true, 34));
        //    alumnosSinAula[33].Responsable = responsables[33];
        //    alumnosSinAula[33].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Kathy", "Stranahan", 650054353, false, 35));
        //    alumnosSinAula[34].Responsable = responsables[34];
        //    alumnosSinAula[34].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Ernie", "Gluyas", 686803651, false, 36));
        //    alumnosSinAula[35].Responsable = responsables[35];
        //    alumnosSinAula[35].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Christoforo", "Swatheridge", 789912923, true, 37));
        //    alumnosSinAula[36].Responsable = responsables[36];
        //    alumnosSinAula[36].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Lorinda", "Yuryatin", 160140667, false, 38));
        //    alumnosSinAula[37].Responsable = responsables[37];
        //    alumnosSinAula[37].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Annecorinne", "Childers", 685808673, false, 39));
        //    alumnosSinAula[38].Responsable = responsables[38];
        //    alumnosSinAula[38].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Cornall", "Elmes", 855451136, false, 40));//
        //    alumnosSinAula[39].Responsable = responsables[39];
        //    alumnosSinAula[39].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Phylis", "Vear", 850789398, false, 41));
        //    alumnosSinAula[40].Responsable = responsables[40];
        //    alumnosSinAula[40].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Hersch", "Hedingham", 678469396, true, 42));
        //    alumnosSinAula[41].Responsable = responsables[41];
        //    alumnosSinAula[41].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Susannah", "O'Day", 789564390, true, 43));
        //    alumnosSinAula[42].Responsable = responsables[42];
        //    alumnosSinAula[42].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Danya", "Frosdick", 304049060, true, 44));
        //    alumnosSinAula[43].Responsable = responsables[43];
        //    alumnosSinAula[43].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Allis", "Ferrieri", 880198979, false, 45));
        //    alumnosSinAula[44].Responsable = responsables[44];
        //    alumnosSinAula[44].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Karine", "Tackell", 512432738, false, 46));
        //    alumnosSinAula[45].Responsable = responsables[45];
        //    alumnosSinAula[45].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Leonidas", "Romaynes", 104516376, true, 47));
        //    alumnosSinAula[46].Responsable = responsables[46];
        //    alumnosSinAula[46].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Lorna", "Billett", 854702983, false, 48));
        //    alumnosSinAula[47].Responsable = responsables[47];
        //    alumnosSinAula[47].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Gabie", "Sinkin", 617904301, false, 49));
        //    alumnosSinAula[48].Responsable = responsables[48];
        //    alumnosSinAula[48].Legajo = legajo;
        //    legajo++;
        //    alumnosSinAula.Add(new Alumno("Web", "Grassett", 396218126, false, 50));//
        //    alumnosSinAula[49].Responsable = responsables[49];
        //    alumnosSinAula[49].Legajo = legajo;
        //    legajo++;

        //    //aulas.Add(new Aula(EColor.Amarillo, docentes[0], ETurno.Mañana));
        //    //aulas[0].Alumnos.Add(alumnosSinAula[0]);
        //    //alumnosSinAula[0].ColorSala = aulas[0].ColorSala;
        //    //alumnosConAula.Add(alumnosSinAula[0]);
        //    //alumnosSinAula.Remove(alumnosSinAula[0]);


        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosSinAula.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));

        //        ser.Serialize(Escribir, AlumnosSinAula);
        //    }

            

        //    //aulas.Add(new Aula(EColor.Naranja, docentes[1], ETurno.Mañana));
        //    //aulas.Add(new Aula(EColor.Rojo, docentes[2], ETurno.Mañana));
        //    //aulas.Add(new Aula(EColor.Verde, docentes[3], ETurno.Mañana));
        //    //aulas.Add(new Aula(EColor.Amarillo, docentes[4], ETurno.Tarde));


        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosConAula.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));
        //        //ser.Serialize(Escribir, AlumnosConAula);
        //    }

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Aulas.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Aula>)));
        //        //ser.Serialize(Escribir, Aulas);
        //    }

        //}//Fin Harcodeo
        #endregion

        //MENUES
        #region menues
        private void ocultarSubMenu()
        {
            if (panelSubMenuArchivo.Visible == true)
            {
                panelSubMenuArchivo.Visible = false;
            }
            else if (panelSubMenuReporte.Visible == true)
            {
                panelSubMenuReporte.Visible = false;
            }
        }

        //Hace visuble el submenu de cada boton
        private void showSubMenu(Panel subMenu)
        {

            switch (subMenu.Name)
            {
                case "panelSubMenuArchivo":
                        if (subMenu.Visible == false)
                        {
                        subMenu.Visible = true;
                         }
                        else
                         {
                            subMenu.Visible = false;
                            panelSubAltas.Visible = false;
                            panelSubBajas.Visible = false;
                            panelSubModificar.Visible = false;
                        }
                        subMenu.Width = 141;
                        subMenu.Height = 125;
                   
                    break;
                case "panelSubMenuReporte":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                    }
                    else
                    {
                        subMenu.Visible = false;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 200;
                    

                    break;
                case "panelSubAltas":
               
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 250;
                        panelSubBajas.Visible = false;
                        panelSubModificar.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 125;
                    break;
                case "panelSubBajas":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 285;
                        panelSubAltas.Visible = false;
                        panelSubModificar.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 160;
                    break;
                case "panelSubModificar":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 285;
                        panelSubBajas.Visible = false;
                        panelSubAltas.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 160;
                    break;
            }
        }
        #endregion

        //  Archivo y SUBMENUS PRINCIPALES
        #region Archivo
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            showSubMenu(panelSubMenuArchivo);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubAltas);
        }
        private void btnBajas_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubBajas);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubModificar);
        }




        // BOTONES DE ALTA
        #region

        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAltaAlumno = new FrmAltaAlumno();
            instAltaAlumno.Legajo = legajo;
            instAltaAlumno.ListResponsables = Responsables;
            if (instAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                this.alumnosSinAula.Add(instAltaAlumno.UnAlumno);
                legajo = instAltaAlumno.Legajo;
                // instAlumnos = new FrmAlumnos(alumnosSinAula, "Sin Aula");
                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = alumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta del Alumno");
            }
        }

        private void btnAltaDocente_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAlta = new FrmAltaPersonal();
            instAlta.SetDocente();
            if (instAlta.ShowDialog() == DialogResult.OK)
            {
                this.Docentes.Add(instAlta.UnDocente);
                instDocentes = new FrmDocente(Docentes);
                this.AbrirFormHijo(instDocentes);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta del Docente");
            }
        }


        private void btnAltaAdministrativo_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAlta = new FrmAltaPersonal();
            instAlta.SetNoDocente();
            if (instAlta.ShowDialog() == DialogResult.OK)
            {
                this.NoDocentes.Add(instAlta.UnNoDocente);
                instNoDocente = new FrmNoDocente(NoDocentes);
                this.AbrirFormHijo(instNoDocente);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta de Administrativo");
            }
        }
        private void btnAltaAula_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();


            instAltaAula = new FrmAltaAula();
            instAltaAula.ListAlumnosConAula = AlumnosConAula;
            instAltaAula.ListAlumnosSinAula = AlumnosSinAula;
            instAltaAula.ListDocentesDisponibles = docentes;
            instAltaAula.ListAulas = Aulas;


            if (instAltaAula.ShowDialog() == DialogResult.OK)
            {
                this.Aulas = instAltaAula.ListAulas;
                this.AlumnosSinAula = instAltaAula.ListAlumnosSinAula;
                this.AlumnosConAula = instAltaAula.ListAlumnosConAula;
                this.Docentes = instAltaAula.ListDocentesDisponibles;

                this.instAula = new FrmAula(Aulas);
                this.AbrirFormHijo(instAula);
                this.instAlumnos = new FrmAlumnos();
                this.instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                this.instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta de Aula");
            }
        }
        #endregion


        //BOTONES DE BAJA     -- ANDA PERO HAY QUE REVISAR
        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            instBaja = new FrmBaja();
            instBaja.ListAlumnosConAula = AlumnosConAula;
            instBaja.ListAlumnosSinAula = AlumnosSinAula;
            instBaja.ListAulas = Aulas;
            instBaja.CargarFormAlumno();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instBaja.ListAlumnosConAula;
                AlumnosSinAula = instBaja.ListAlumnosSinAula;
                Aulas = instBaja.ListAulas;

                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
        }
        private void btnBajaResponsable_Click(object sender, EventArgs e)
        {
            instBaja = new FrmBaja();
            instBaja.ListResponsables = Responsables;
            instBaja.ListAlumnosConAula = AlumnosConAula;
            instBaja.ListAlumnosSinAula = AlumnosSinAula;
            instBaja.CargarFormResponsable();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                Responsables = instBaja.ListResponsables;
                AlumnosConAula = instBaja.ListAlumnosConAula;
                AlumnosSinAula = instBaja.ListAlumnosSinAula;

                instResponsables = new FrmResponsables(Responsables);
                this.AbrirFormHijo2(instResponsables);
            }
        }
        private void btnBajaDocente_Click(object sender, EventArgs e)
        {
            instBaja = new FrmBaja();
            instBaja.ListDocentes = Docentes;
            instBaja.ListAulas = Aulas;
            instBaja.CargarFormDocente();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                Docentes = instBaja.ListDocentes;
                Aulas = instBaja.ListAulas;

                instDocentes = new FrmDocente(Docentes);
                this.AbrirFormHijo(instDocentes);
            }
        }
        private void btnBajaAdministrativo_Click(object sender, EventArgs e)
        {
            instBaja = new FrmBaja();
            instBaja.ListAdministrativo = NoDocentes;
            instBaja.CargarFormAdministrativo();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                NoDocentes = instBaja.ListAdministrativo;

                instNoDocente = new FrmNoDocente(NoDocentes);
                this.AbrirFormHijo(instNoDocente);
            }
        }
        private void btnBajaAula_Click(object sender, EventArgs e)
        {
            instBajaAula = new FrmBajaAula();
            instBajaAula.ListAlumnosConAula = AlumnosConAula;
            instBajaAula.ListAlumnosSinAula = AlumnosSinAula;
            instBajaAula.ListAulas = Aulas;
            if (instBajaAula.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instBajaAula.ListAlumnosConAula;
                AlumnosSinAula = instBajaAula.ListAlumnosSinAula;
                Aulas = instBajaAula.ListAulas;

                instAula = new FrmAula(Aulas);
                this.AbrirFormHijo(instAula);

            }
        }
        //BOTONES DE MOFICICAR
        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            instEditarAlumno = new FrmEditarAlumno();
            instEditarAlumno.ListAlumnosConAula = AlumnosConAula;
            instEditarAlumno.ListAlumnosSinAula = AlumnosSinAula;
            instEditarAlumno.ListResponsables = Responsables;
            instEditarAlumno.ListAulas = Aulas;
            if (instEditarAlumno.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instEditarAlumno.ListAlumnosConAula;
                AlumnosSinAula = instEditarAlumno.ListAlumnosSinAula;
                Aulas = instEditarAlumno.ListAulas;

                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
        }
        private void btnEditarResponsable_Click(object sender, EventArgs e)
        {
            instEditarResponsable = new FrmEditarResponsable();
            instEditarResponsable.ListAlumnosConAula = AlumnosConAula;
            instEditarResponsable.ListAlumnosSinAula = AlumnosSinAula;
            instEditarResponsable.ListResponsables = Responsables;
            instEditarResponsable.ListAulas = Aulas;
            if (instEditarResponsable.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instEditarResponsable.ListAlumnosConAula;
                AlumnosSinAula = instEditarResponsable.ListAlumnosSinAula;
                Responsables = instEditarResponsable.ListResponsables;
                Aulas = instEditarResponsable.ListAulas;

                instResponsables = new FrmResponsables(Responsables);
                this.AbrirFormHijo2(instResponsables);
            }
        }
        private void btnEditarDocente_Click(object sender, EventArgs e)
        {
            //TERMINAR EDITAR DOCENTE
        }
        private void btnEditarAdministrtivo_Click(object sender, EventArgs e)
        {
            instEditarAdministrativo = new FrmEditarAdministrativo();
            instEditarAdministrativo.ListAdministrativos = NoDocentes;
            if (instEditarAdministrativo.ShowDialog() == DialogResult.OK)
            {
                NoDocentes = instEditarAdministrativo.ListAdministrativos;

                instNoDocente = new FrmNoDocente(NoDocentes);
                this.AbrirFormHijo(instNoDocente);
            }
        }
        private void btnEditarAula_Click(object sender, EventArgs e)
        {

        }

        #endregion//FIN MENUES PRINCIPALES

        //Reporte y SubMenu
        #region Reporte

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            showSubMenu(panelSubMenuReporte);
        }

        private void btnInfoPadres_Click(object sender, EventArgs e)
        {
            instListadoPadres = new FrmListadoPadres(aulas);
            instListadoPadres.Show();
        }

        private void btnSueldoDocente_Click(object sender, EventArgs e)
        {
            instDinero = new FrmDinero();
            instDinero.ListDocentes = docentes;
            instDinero.CargarSueldoDocentes();
            instDinero.ShowDialog();
        }

        private void btnSueldoNoDocente_Click(object sender, EventArgs e)
        {
            instDinero = new FrmDinero();
            instDinero.ListNoDocentes = noDocentes;
            instDinero.CargarSueldoNoDocentes();
            instDinero.ShowDialog();

        }

        private void btnRecTotalJardin_Click(object sender, EventArgs e)
        {
            instDinero = new FrmDinero();
            instDinero.ListAlumnoSinAula = alumnosSinAula;
            instDinero.ListAlumnoConAula = alumnosConAula;
            instDinero.CargarRecaudacionTotal();
            instDinero.ShowDialog();
        }

        private void btnAumnosPorAula_Click(object sender, EventArgs e)
        {
            if (aulas.Count > 0)
            {
                instAlumnosPorAula = new FrmAlumnosPorAula(alumnosConAula, aulas);
                instAlumnosPorAula.Show();
            }
            else
            {
                MessageBox.Show("NO existen las aulas ahora es todo por intenet #QUEDATEENCASA \n\nCREA UN AULA PRIMERO =)");
            }
            
        }

        #endregion



        // Botones
        #region BOTONES PRINCIPALES
        private void btnAulas_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (aulas.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Aula.");
            }
            else
            {
               AbrirFormHijo(instAula);
            }
        }

        private void btnNoDocente_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (noDocentes.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un No Docente.");
            }
            else
            {
                AbrirFormHijo(instNoDocente);
            }
        }

        
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (docentes.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Docente.");
            }
            else
            {
                AbrirFormHijo(instDocentes);
            }
        }

        private void btnResponsables_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (responsables.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Responsable.");
            }
            else
            {
                AbrirFormHijo2(instResponsables);
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();



            if (alumnosSinAula.Count == 0 && alumnosConAula.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Alumno.");
            }
            else
            {
                if (MessageBox.Show("Con aula asignada ?", "Mostrar Alumnos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    instAlumnos = new FrmAlumnos();
                    instAlumnos.ListAlumnosConAula = alumnosConAula;
                    instAlumnos.CargarConAula();
                    AbrirFormHijo2(instAlumnos);
                }
                else
                {
                    instAlumnos = new FrmAlumnos();
                    instAlumnos.ListAlumnosSinAula = alumnosSinAula;
                    instAlumnos.CargarSinAula();
                    AbrirFormHijo2(instAlumnos);
                }
            }
        }
        #endregion


        //TIME Y LOAD
        #region TIME Y LOAD
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_Timer.Text = DateTime.Now.ToString("hh:mm:ss");
            Lb_Fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            //Serializacion de archivo XML
            using (XmlTextReader Leer = new XmlTextReader(Path + "\\AlumnosSinAula.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Alumno>));

                alumnosSinAula = (List<Alumno>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\AlumnosConAula.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Alumno>));

                alumnosConAula = (List<Alumno>)ser.Deserialize(Leer);
            }
            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Aulas.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Aula>));

                aulas = (List<Aula>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Responsables.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Responsable>));

                responsables = (List<Responsable>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Docentes.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Docente>));

                docentes = (List<Docente>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\NoDocentes.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Administrativo>));

                noDocentes = (List<Administrativo>)ser.Deserialize(Leer);
            }

            
            //Fin Serializacion

            //Instacio los formularios hijos y abro 2 en el formulario principal
            instNoDocente = new FrmNoDocente(noDocentes);
            instResponsables = new FrmResponsables(responsables);
            instAula = new FrmAula(aulas);

            instAlumnos = new FrmAlumnos();
            instAlumnos.ListAlumnosSinAula = alumnosSinAula;
            instAlumnos.CargarSinAula();

            instDocentes = new FrmDocente(docentes);
            AbrirFormHijo(instDocentes);
            AbrirFormHijo2(instAlumnos);
        }




        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Cerrando Programa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //Serializo para guardar los cambios en las lisas de entidades
                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Docentes.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Docente>)));

                    ser.Serialize(Escribir, docentes);
                }
                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\NoDocentes.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Administrativo>)));

                    ser.Serialize(Escribir, noDocentes);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Responsables.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Responsable>)));

                    ser.Serialize(Escribir, responsables);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosSinAula.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));

                    ser.Serialize(Escribir, alumnosSinAula);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosConAula.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));
                    ser.Serialize(Escribir, alumnosConAula);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Aulas.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Aula>)));
                    ser.Serialize(Escribir, aulas);
                }

            }

        }

        //private void btnHardcodear_Click(object sender, EventArgs e)
        //{
        //    harcodear();
        //    instNoDocente = new FrmNoDocente(noDocentes);
        //    instResponsables = new FrmResponsables(responsables);
        //    instAula = new FrmAula(aulas);

        //    instAlumnos = new FrmAlumnos();
        //    instAlumnos.ListAlumnosSinAula = alumnosSinAula;
        //    instAlumnos.CargarSinAula();

        //    instDocentes = new FrmDocente(docentes);
        //    AbrirFormHijo(instDocentes);
        //    AbrirFormHijo2(instAlumnos);
        //    btnHardcodear.Enabled = false;
        //    btnHardcodear.Visible = false;
        //}

        private void btnVideos_Click(object sender, EventArgs e)
        {
            intMediaPlayer = new FrmMediaPlayer();
            intMediaPlayer.Show();
        }

    }//
}//
