using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    public class Evaluacion
    {

        int idEvaluacion;
        int idAlumno;
        int idDocente;
        int idAula;
        int nota_Uno;
        int nota_Dos;
        float nota_Final;
        string observaciones;


        public Evaluacion()
        {

        }

        public Evaluacion(int idEvaluacion, int idAlumno, int idDocente, int idAula, int nota1, int nota2, float notaFinal, string observaciones)
        {
            this.IdEvaluacion = idEvaluacion;
            this.IdAlumno = idAlumno;
            this.IdDocente = idDocente;
            this.IdAula = idAula;
            this.nota_Uno = nota1;
            this.nota_Dos = nota2;
            this.nota_Final = notaFinal;
            this.Observaciones = observaciones;  
        }

        public int IdEvaluacion
        {
            get { return this.idEvaluacion; }
            set { this.idEvaluacion = value; }
        }
        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }

        public int IdDocente
        {
            get { return this.idDocente; }
            set { this.idDocente = value; }
        }
        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }
        public int NotaUno
        {
            get { return this.nota_Uno; }
            set { this.nota_Uno = value; }
        }
        public int NotaDos
        {
            get { return this.nota_Dos; }
            set { this.nota_Dos = value; }
        }
        public float NotaFinal
        {
            get { return this.nota_Final; }
            set { this.nota_Final = value; }
        }
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }



    }//
}//
