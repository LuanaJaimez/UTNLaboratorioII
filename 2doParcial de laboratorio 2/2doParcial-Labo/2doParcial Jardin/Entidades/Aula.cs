using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    public class Aula : IMensaje<Aula>
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        //public Docente Docente
        //{
        //    get { return this.docente; }
        //    set { this.docente = value; }
        //}
        public ETurno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }

        public Aula AutoReferencia
        {
            get { return this; }
            set { this.docente = value.docente; }
        }
        #endregion

        #region Constructores
        public Aula(EColores colorSala, ETurno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }
        #endregion

        #region Operadores
        public static bool operator +(Aula aula, Alumno alumno)
        {
            return true;
        }
        #endregion
        //Cada aula tiene un docente y no mas de 30 alumnos
        public void ValidoAula() 
        {
            if(alumnos.Count > 30)
            {
                Aula aulaNueva = new Aula(this.colorSala, this.turno, this.docente);
            }
            else
            {
                Console.WriteLine("No se pudo crear una aula nueva."); 
            }
        }

        public string MostrarMensaje()
        {
            return this.ToString();
        }
    }
}
