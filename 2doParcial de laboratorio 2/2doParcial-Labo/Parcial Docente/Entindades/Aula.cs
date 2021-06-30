using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    public class Aula
    {
        int idAula;
        string color;

        public Aula()
        {

        }
        public Aula(int id, string color)
        {
            this.IdAula = id;
            this.Color = color;
        }

        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


    }//
}//
