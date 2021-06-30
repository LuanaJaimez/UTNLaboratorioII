using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FormularioDocente
{
    public class SerializacionXML
    {
        public static void Serializar(Object objetoSerializar, string directorio)
        {
            XmlSerializer serializar = new XmlSerializer(objetoSerializar.GetType());
            FileStream fstream = File.Open(directorio, FileMode.Create, FileAccess.Write);
            serializar.Serialize(fstream, objetoSerializar);
            fstream.Close();
            fstream.Dispose();
        }
        public static Object Deserializar <T>(string directorio)
        {
            XmlSerializer serializar = new XmlSerializer(typeof(T));
            FileStream fStream = File.Open(directorio, FileMode.Open);
            Object objDeserializado = serializar.Deserialize(fStream);
            fStream.Close();
            fStream.Dispose();
            return objDeserializado;
        }
        public static void SerializarBinaria(Object objetoSerializar, string directorio)
        {
            BinaryFormatter serializarBinario = new BinaryFormatter();
            Stream stream = new FileStream(directorio, FileMode.Create, FileAccess.Write,FileShare.None);
            serializarBinario.Serialize(stream, objetoSerializar);
            stream.Close();
            stream.Dispose();
        }

        public static Object DeserealizoBinaria<T>(string directorio)
        {
            Stream stream = new FileStream(directorio, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter formateador = new BinaryFormatter();
            Object aux = (Object)(T)formateador.Deserialize(stream);
            stream.Close();
            stream.Dispose();
            return aux;
        }


    }
}
