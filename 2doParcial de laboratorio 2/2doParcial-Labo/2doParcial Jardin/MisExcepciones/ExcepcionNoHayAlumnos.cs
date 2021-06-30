using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    [Serializable]
    public class ExcepcionNoHayAlumnos : Exception
    {
        public string NombreEstudiante { get; }

        public ExcepcionNoHayAlumnos() { }

        public ExcepcionNoHayAlumnos(string mens)
            : base(mens) { }

        public ExcepcionNoHayAlumnos(string mens, Exception inner)
            : base(mens, inner) { }

        public ExcepcionNoHayAlumnos(string mens, string nombreDelEstudiante)
            : this(mens)
        {
            NombreEstudiante = nombreDelEstudiante;
        }
    }
}
