using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EParentesco
    {
        Madre,
        Padre,
        Tia,
        Tio,
        Abuela,
        Abuelo,
        Otro
    }
    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;
        private Alumno alumnoRes;

        #region Propiedades
        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        #endregion

        #region Constructores
        public Responsable()
        {

        }
        public Responsable(Alumno alu)
        {
            this.alumnoRes = new Alumno();
            this.alumnoRes = alu;
        }
        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string tel) : base( nombre, apellido, dni, femenino)
        {
            //Responsable res = new Responsable(nombre, apellido, dni, femenino, parentesco, tel);
            this.parentesco = parentesco;
            this.telefono = tel;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            
            st.AppendLine("\n----------------------------------------------");
            st.AppendLine("Datos del Responsable");
            st.AppendLine("----------------------------------------------");
            st.AppendLine(base.ToString());
            st.AppendLine("Parentesco: " + this.Parentesco);
            st.AppendLine("Telefono: " + this.Telefono);
            st.AppendLine("_______________________________________________");
            return st.ToString();

        }



    }
}
