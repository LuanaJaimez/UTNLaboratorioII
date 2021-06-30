using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Aula))]
    public class Aula // : IMensaje<Aula>
    {
        private List<Alumno> alumnos;
        private EColor colorSala;
        private Docente docente;
        private ETurno turno;

        public Aula()
        {

        }

        public Aula(EColor colorSala, Docente docente, ETurno turno)
        {
            this.colorSala = colorSala;
            this.docente = docente;
            this.turno = turno;
            alumnos = new List<Alumno>();
        }

        public Alumno this[int index]
        {
            get { return this.alumnos[index]; }
            set { this.alumnos[index] = value; }
        }


        public EColor ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }

        public ETurno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

      
        //REVISAR PORQUE ROMPE
        public static bool operator +(Aula aula, Alumno alumno)
        {

                if (!(aula is null) && !(alumno is null) )
                {
                  if (!(aula.alumnos.Contains(alumno) && aula.alumnos.Count < 30 ))
                  {
                      aula.alumnos.Add(alumno);
                      return true;
                  }
                }
            return false;
        }

        public static bool operator ==(Aula aula1, Aula aula2)
        {

            if (!(aula1 is null) && !(aula2 is null))
            {
                if (aula1.colorSala == aula2.colorSala && aula1.turno == aula2.turno)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Aula aula1, Aula aula2)
        {
            return !(aula1 == aula2);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Color de Sala: {this.colorSala}");
            sb.Append($"Turno: {this.turno}");
            sb.Append($"Docente: {this.docente}");

            return sb.ToString();
        }


        // INTERFACE 

        //public Aula AutoReferencia { 
        //    get { return this; }
        //    set { this.Docente = value.Docente; }
        //}

        //public string MostrarMsj()
        //{
        //    return this.ToString();
        //}





    }//
}//
