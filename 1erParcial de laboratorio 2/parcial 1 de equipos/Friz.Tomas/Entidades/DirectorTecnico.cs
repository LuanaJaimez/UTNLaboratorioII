using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Constructor
        public DirectorTecnico(string nombre,string apellido):base(nombre,apellido)
        {

        }
        #endregion

        #region Metodos
        protected override string FichaTecnica()
        {
            return base.NombreCompleto();
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            return this.FichaTecnica();
        }
        #endregion
    }
}
