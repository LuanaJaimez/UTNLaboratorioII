using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PersonaInvalidaException : Exception
    {
        public PersonaInvalidaException(string message, Exception innerException)
        {

        }

        public PersonaInvalidaException(string message) : base(message)
        {

        }


    }//
}//
