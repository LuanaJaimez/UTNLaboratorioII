using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDocente
{
    public class Evaluaciones
    {
        int idEvaluacion;
        int idAlumno;
        int idDocente;
        int idAula;
        int nota_1;
        int nota_2;
        float notaFinal;
        string observaciones;

        List<Alumnos> listAl;

        #region Propiedades
        public int IdEvaluacion { get => idEvaluacion; set => idEvaluacion = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int IdDocente { get => idDocente; set => idDocente = value; }
        public int IdAula { get => idAula; set => idAula = value; }
        public int Nota_1 { get => nota_1; set => nota_1 = value; }
        public int Nota_2 { get => nota_2; set => nota_2 = value; }
        public float NotaFinal { get => notaFinal; set => notaFinal = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        #endregion
        public Evaluaciones()
        {
            listAl = new List<Alumnos>();
        }
        public Evaluaciones(List<Alumnos> lstAlu) :this()
        {
            this.listAl = lstAlu;
        }
        public Evaluaciones(int idEval,int idAl,int idDoc,int idAul,int nota1,int nota2,float notaFin,string obser):this()
        {
            this.idEvaluacion = idEval;
            this.idAlumno = idAl;
            this.idDocente = idDoc;
            this.idAula = idAul;
            this.nota_1 = nota1;
            this.nota_2 = nota2;
            this.notaFinal = notaFin;
            this.observaciones = obser;
        }

    }
}
