using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    public class Validaciones
    {
        public static bool ValidarDouble(string s, double max, double min)
        {

            return (double.TryParse(s, out double retorno) && retorno > min && retorno < max);
        }
        public static bool ValidarEntero(string s, int max, int min)
        {
            return (int.TryParse(s, out int retorno) && retorno > min && retorno < max);
        }
        public static bool ValidarFlotante(string s, float max, float min)
        {
            return (float.TryParse(s, out float retorno) && retorno > min && retorno < max);
        }
        public static bool ValidarString(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }
        public static bool ValidarStringSoloLetras(string cadena)
        {
            char[] alfabeto = "abcdefghijklmñnopqrstuvwxyz ".ToCharArray();
            bool retorno = true;
            int contador = 0;

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {

                foreach (char c in cadena)
                {
                    for (int i = 0; i < alfabeto.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga letras

                        if (c.ToString().ToLower() == alfabeto[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena NO era una letra.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }


        public static bool ValidarStringSoloNumeros(string cadena)
        {
            char[] numeros = "0123456789".ToCharArray();
            bool retorno = true;
            int contador = 0;

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {

                foreach (char c in cadena)
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga numeros

                        if (c.ToString().ToLower() == numeros[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena NO era un numero.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }






    }//
}//
