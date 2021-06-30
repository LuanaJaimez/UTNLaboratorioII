using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    public class Docente : Persona
    {
        int idDocente;
        string sexo;
        string email;

        public Docente() : base()
        {

        }

        public Docente(string nombre, string apellido, int dni, int edad, string direccion, int id, string sexo, string email) 
            : base(nombre, apellido, dni, edad, direccion)
        {
            this.idDocente = id;
            this.Email = email;
            this.Sexo = sexo;        
        }

        public int IdDocente
        {
            get { return this.idDocente; }
            set { this.idDocente = value; }
        }

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }






    }//
}//
