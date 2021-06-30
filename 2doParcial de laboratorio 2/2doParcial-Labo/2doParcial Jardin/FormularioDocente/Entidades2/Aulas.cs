using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDocente
{
    public class Aulas
    {
        string salita;
        int idAula;
        public string Salita { get => salita; set => salita = value; }
        public int IdAula { get => idAula; set => idAula = value; }

        public Aulas()
        {
            
        }
        public Aulas(string _salita, int id)
        {
            this.salita = _salita;
            this.idAula = id;
        }

    }
}
