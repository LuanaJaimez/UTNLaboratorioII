using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace FormularioDocente
{
    public class Alumnos : Persona
    {
        private int idAlumnos;
        private int edad;
        private string direccion;
        private string responsable;
        private int idAula;
        public int IdAlumnos { get => idAlumnos; set => idAlumnos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public int IdAula { get => idAula; set => idAula = value; }

        public Alumnos()
        {


        }
        public Alumnos(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {

        }
        public Alumnos(string nombre, string apellido, int dni, int eda, string direc, string resp) : this(nombre, apellido, dni)
        {
            this.Edad = eda;
            this.Direccion = direc;
            this.Responsable = resp;
        }
        public Alumnos(string nombre, string apellido, int dni, int eda, string direc, string resp, int IdAula, int idAlumnos) : base(nombre, apellido, dni)
        {
            this.edad = eda;
            this.direccion = direc;
            this.responsable = resp;
            this.IdAula = IdAula;
            this.idAlumnos = idAlumnos;
        }

    }
}
