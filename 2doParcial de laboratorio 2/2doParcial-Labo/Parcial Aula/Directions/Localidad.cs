using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direccion
{
    public class Localidad<H> where H : Direc, new()
    {

        decimal id;
        decimal idProvincia;
        string nombre;

        public Localidad(decimal id, decimal idProvincia, string nombre)
        {
            this.id = id;
            this.idProvincia = idProvincia;
            this.nombre = nombre;
        }

        public decimal Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public decimal IdProvincia
        {
            get { return this.idProvincia; }
            set { this.idProvincia = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


        public override string ToString()
        {
            return this.Nombre;
        }


    }//
}//
