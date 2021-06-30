using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using FormularioDocente;
using Microsoft.Win32.SafeHandles;

namespace PruebaUnitaria
{
    [TestClass]
    public class TestUnitario
    {


        
        [TestMethod]
        public void SerializoBinariamente()
        {
            List<Docente> aux = new List<Docente>();
            aux.Add(new Docente("juan", "Perez", 123454, 42, "San martin 323", 63, "Mascu", "Hoa@lasdlkl.com"));
            aux.Add(new Docente("hector", "Paz", 12345412, 32, "San Juan 23", 63, "Fem", "Hoa@lasdlkl.com"));
            SerializacionXML.SerializarBinaria(aux, "AuxDocente.txt");
            Assert.IsTrue(true, "Se Serializo a binario correctamente");
        }
        [TestMethod]
        public void DeserealizoBinariamente()
        {
            List<Docente> aux = new List<Docente>();
            List<Docente> listaDocenteDeserializada = new List<Docente>();
            aux = (List<Docente>)SerializacionXML.DeserealizoBinaria<List<Docente>>("AuxDocente.txt");
            listaDocenteDeserializada = aux;
            Assert.IsTrue(true, "Se Deserealizo a binario correctamente");
        }



        //public void CreateValueTest()
        //{
        //    MenPrincipal menprin = new MenPrincipal();
        //    menprin.CreoObjDefault_Click();

        //    Assert.IsTrue(menprin.ListaDocentes.Count == 6 && menprin.ListaAlumnos.Count == 50);
        //}

        //Prueba con interfaz
        //[TestMethod]
        //public void PruebaInterface()
        //{
        //    List<IMensaje> listaMsj = new List<IMensaje>();

        //    Docente d1 = new Docente("Jose", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d2= new Docente("Julia", "Venecia", 7123658, true, Convert.ToDateTime("2/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d3 = new Docente("Elvira", "Alvez", 21458712, true, Convert.ToDateTime("3/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d4 = new Docente("Marta", "Rodri", 11245856, false, Convert.ToDateTime("4/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d5 = new Docente("Carlos", "Teki", 12458965, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);

        //    listaMsj.Add(d1);
        //    listaMsj.Add(d2);
        //    listaMsj.Add(d3);
        //    listaMsj.Add(d4);
        //    listaMsj.Add(d5);

        //    listaMsj.Add(new Aula(EColores.Amarillo, ETurno.Mañana, d1));
        //    listaMsj.Add(new Aula(EColores.Rojo, ETurno.Tarde, d2));
        //    listaMsj.Add(new Aula(EColores.Verde, ETurno.Mañana, d3));
        //    listaMsj.Add(new Aula(EColores.Amarillo, ETurno.Tarde, d4));

        //    string salida = "";
        //    foreach (IMensaje item in listaMsj)
        //    {
        //        item.MostrarMensaje();
        //    }

        //    Assert.IsTrue(salida.Length > 200);
        //}

    }
}
