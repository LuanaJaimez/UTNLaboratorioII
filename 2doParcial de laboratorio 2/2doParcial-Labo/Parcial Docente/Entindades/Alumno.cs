using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    [Serializable]
    public class Alumno : Persona
    {

        int idAlumno;
        int notaUno;
        int notaDos;
        int idAula;
        string responsable;
        float notaFinal;
        Random random;

        public Alumno() : base()
        {

        }

        public Alumno(string nombre, string apellido, int dni, int edad, string direccion, int id, string responsable) 
            : base(nombre,apellido,dni,edad,direccion)
        {
            this.IdAlumno = id;
            this.Responsable = responsable;
            random = new Random();
        }
        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }
        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }
        public string Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public float NotaFinal
        {
            get { return this.notaFinal; }
            set { this.notaFinal = value; }
        }
        public int NotaUno
        {
            get { return this.notaUno; }
            set { this.notaUno = value; }
        }
        public int NotaDos
        {
            get { return this.notaDos; }
            set { this.notaDos = value; }
        }

        public void CargarNota()
        {
            this.NotaUno = random.Next(1, 10);
            this.NotaDos = random.Next(1, 10);
            this.NotaFinal = (this.NotaUno + this.NotaDos) / 2;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Nombre} {this.Apellido}");
            return sb.ToString();
        }


    }//
}//
