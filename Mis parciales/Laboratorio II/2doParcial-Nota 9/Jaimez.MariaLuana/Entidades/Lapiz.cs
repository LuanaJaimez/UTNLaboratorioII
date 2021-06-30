using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        #region Atributos
        public enum ETipoTrazo { Fino, Grueso, Medio }
        public ConsoleColor color;
        public ETipoTrazo trazo;
        #endregion

        #region Propiedades
        public override bool PreciosCuidados 
        { 
            get 
            { 
                return true; 
            } 
        }

        public string Path
        {
            get
            {
                return Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString() + "\\Jaimez.Luana.lapiz.xml";
            }
        }
        #endregion

        #region Constructores
        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public Lapiz() : base()
        {
        
        }
        #endregion

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.UtilesToString());
            cadena.AppendFormat("Trazo: {0}\nColor: {1}\nPrecio Cuidado: {2}", this.trazo, this.color.ToString(), this.PreciosCuidados);

            return cadena.ToString();
        }

        public bool Xml()
        {
            bool retorno = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    ser.Serialize(writer, this);
                }

            }
            catch (Exception)
            {
                retorno = false;

            }

            return retorno;
        }

        bool IDeserializa.Xml(out Lapiz l)
        {
            bool retorno = true;

            try
            {
                using (XmlTextReader read = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    l = (Lapiz)ser.Deserialize(read);

                }

            }
            catch (Exception)
            {
                retorno = false;
                l = new Lapiz();
            }

            return retorno;

        }
    }
}
