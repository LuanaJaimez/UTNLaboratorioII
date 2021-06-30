using System;
using System.IO;
using Archivos;
using Entindades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestSerializeXmlBinary
    {
        [TestMethod]
        public void SerializeXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\SegundoParcialUtn\\JardinUtn\\Alumnos.xml";
            Alumno alumno = new Alumno("Manuel","Clifton",36105581,29,"Av San Juan 3169", 256,"Juan Roman Riquelme");

            Xml<Alumno> xml = new Xml<Alumno>();

            Assert.IsTrue(xml.GuardarXml(path, alumno));
        }

        [TestMethod]
        public void SerializeBinary()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\SegundoParcialUtn\\JardinUtn\\Alumnos.dat";
            Alumno alumno = new Alumno("Manuel", "Clifton", 36105581, 29, "Av San Juan 3169", 256, "Juan Roman Riquelme");
            Alumno alumAux = new Alumno();
            DateTime fecha = DateTime.Now;

            Xml<Alumno> xml = new Xml<Alumno>();

            Assert.IsTrue(xml.GuardarBinario(path, alumno));
        }

        [TestMethod]
        public void DeserializeXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\SegundoParcialUtn\\JardinUtn\\Alumnos.xml";
            Alumno alumno = new Alumno("Manuel", "Clifton", 36105581, 29, "Av San Juan 3169", 256, "Juan Roman Riquelme");
            Alumno alumAux = new Alumno();

            DateTime fecha = DateTime.Now;
            Xml<Alumno> xml = new Xml<Alumno>();
            xml.GuardarXml(path, alumno);

            Assert.IsTrue(xml.Leer(path, out alumAux)); 
        }


        [TestMethod]
        public void DeserializeBinary()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\SegundoParcialUtn\\JardinUtn\\Alumnos.dat";

            Alumno alumno = new Alumno("Manuel", "Clifton", 36105581, 29, "Av San Juan 3169", 256, "Juan Roman Riquelme");
            Alumno aux = new Alumno();
            DateTime fecha = DateTime.Now;

            Xml<Alumno> xml = new Xml<Alumno>();

            xml.GuardarBinario(path, alumno);

            Assert.IsTrue(xml.LeerBinario(path, out aux));

        }



    }//
}//
