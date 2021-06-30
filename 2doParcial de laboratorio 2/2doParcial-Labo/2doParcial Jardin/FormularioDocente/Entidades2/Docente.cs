using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace FormularioDocente
{
    [Serializable]
    public class Docente : Persona
    {
		public List<Docente> listaDocente;
		int idDocente;
		//public string nombre;
		//public string apellido;
		public int edad;
		//public int dni;
		public string direccion;
		public int id;
		public string sexo;
		public string email;

		//public string Nombre { get => nombre; set => nombre = value; }
		//public string Apellido { get => apellido; set => apellido = value; }
		public int Edad { get => edad; set => edad = value; }
		//public int Dni { get => dni; set => dni = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Id { get => id; set => id = value; }
		public string Sexo { get => sexo; set => sexo = value; }
		public string Email { get => email; set => email = value; }
		public int IdDocente { get => idDocente; set => idDocente = value; }

		public Docente()
		{
			
		}
		public Docente(List<Docente> lista)
		{
			this.listaDocente = new List<Docente>();
			this.listaDocente = lista;
		}

		public Docente(string nombre, string apellido, int dni): base(nombre,apellido,dni)
		{

		}

		public Docente(string nombre, string apellido, int dni, int edad, string direccion, int id, string sexo, string email):this(nombre,apellido,dni)
		{
			
			//this.nombre = nombre;
			//this.apellido = apellido;
			this.edad = edad;
			//this.dni = dni;
			this.direccion = direccion;
			this.id = id;
			this.sexo = sexo;
			this.email = email;
		}
	}
}
