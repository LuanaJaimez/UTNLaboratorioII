using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                    using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer((typeof(T)));

                        ser.Serialize(writer, datos);
                        return true;
                    }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                throw new GuardarLogsException();
            }
        }

        public bool GuardarXml(string archivo, T datos)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(T)));

                    ser.Serialize(writer, datos);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
 
            }
           
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    datos = (T)ser.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new GuardarLogsException();
            }
            
        }


        public bool GuardarBinario(string archivo, T datos)
        {
            BinaryFormatter ser = new BinaryFormatter();

            FileStream fs = new FileStream(archivo, FileMode.Create);
            try
            {
                ser.Serialize(fs, datos);
                return true;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }
        public bool LeerBinario(string archivo, out T datos)
        {
            BinaryFormatter ser = new BinaryFormatter();

            FileStream fst = new FileStream(archivo, FileMode.Open);
            try
            {
                datos = (T)ser.Deserialize(fst);

                return true;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fst.Close();
            }
           
        }




    }//
}//
