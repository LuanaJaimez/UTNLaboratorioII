using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    [Serializable]
    public class ExcepcionBaseDeDatos:Exception
    {
        

        public ExcepcionBaseDeDatos() { }

        public ExcepcionBaseDeDatos(string mens)
            : base(mens) { }

        public ExcepcionBaseDeDatos(string mens, Exception inner)
            : base(mens, inner) { }

        public ExcepcionBaseDeDatos(string mens, string nombreDelEstudiante)
            : this(mens)
        {
            
        }
    }
}
