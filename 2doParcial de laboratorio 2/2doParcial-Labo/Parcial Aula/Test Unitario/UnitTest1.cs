using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Clifton.Manuel;
using System.Collections.Generic;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaInvalidaException))]
        public void PersonaSinDniValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompin", 0, false, 25410);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonaInvalidaException))]
        public void PersonaSinNombreValido()
        {
            Alumno a1 = new Alumno("", "Pompin", 0, false, 25410);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonaInvalidaException))]
        public void PersonaSinApellidoValido()
        {
            Alumno a1 = new Alumno("Pepe", "", 0, false, 25410);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonaInvalidaException))]
        public void PersonaSinCuotaValida()
        {
            Alumno a1 = new Alumno("Pepe", "", 0, false, 0);
        }

        [TestMethod]
        public void AltaAlumnoValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompin", 16547809, false, 25410);

            if (ValidarPersona(a1))  // Agregar  funcion para validar datos del alumno
            {
                Assert.IsNotNull(a1);
            }
        }

        public bool ValidarPersona(Persona p)
        {
            bool flag = false;

            if (p.Dni > 1000000 && Validaciones.ValidarString(p.Nombre) && Validaciones.ValidarString(p.Apellido) )
            {
                flag = true;
            }
            return flag;
        }

        [TestMethod]
        public void PersonaDniValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompin", 16547809, false, 25410);

            Assert.IsNotNull(a1);
        }

        [TestMethod]
        public void PersonaNombreValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompin", 16547809, false, 25410);

            Assert.IsNotNull(a1);
        }

        [TestMethod]
        public void PersonaApellidoValido()
        {
            Alumno a1 = new Alumno("Pepe", "Pompin", 16547809, false, 25410);

            Assert.IsNotNull(a1);
        }


        [TestMethod]
        public void Crear50Profesores()
        {
            FrmPrincipal menuPrincipal = new FrmPrincipal();

            menuPrincipal.harcodear();

            Assert.IsTrue(menuPrincipal.Docentes.Count == 5 && menuPrincipal.alumnosSinAula.Count == 50);
        }

        //+alumno
        public void AulaSinAlumnos()
        {
            FrmPrincipal menuPrincipal = new FrmPrincipal();

            menuPrincipal.harcodear();

            Aula aula = new Aula(EColor.Amarillo, menuPrincipal.Docentes[0] ,ETurno.Tarde);

            Assert.IsTrue(menuPrincipal.Docentes.Count == 5 && menuPrincipal.alumnosSinAula.Count == 50);
        }







        //[TestMethod]
        //public void PruebaInterface()
        //{
        //    List<IMensaje> listaMsj = new List<IMensaje>();


        //    Docente d1 = new Docente("Carlos", "Monzon", 25147896, false, Convert.ToDateTime("1/2/2000 11:30:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250);
        //    Docente d2 = new Docente("Pepe", "Argento", 352478899, false, Convert.ToDateTime("1/2/2000 7:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250);
        //    Docente d3 = new Docente("Lucia", "Gonzalez", 425896377, true, Convert.ToDateTime("1/2/2000 8:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250);
        //    Docente d4 = new Docente("Ana", "Lopez", 547286785, true, Convert.ToDateTime("1/2/2000 12:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250);
        //    Docente d5 = new Docente("Manuel", "Clifton", 68422398, false, Convert.ToDateTime("1/2/2000 9:00:00 AM"), Convert.ToDateTime("5:00:00 PM"), 250);

        //    listaMsj.Add(d1);
        //    listaMsj.Add(d2);
        //    listaMsj.Add(d3);
        //    listaMsj.Add(d4);
        //    listaMsj.Add(d5);

        //    listaMsj.Add(new Aula(EColor.Amarillo, d1, ETurno.Mañana));
        //    listaMsj.Add(new Aula(EColor.Naranja, d2, ETurno.Mañana));
        //    listaMsj.Add(new Aula(EColor.Rojo, d4, ETurno.Mañana));
        //    listaMsj.Add(new Aula(EColor.Verde, d5, ETurno.Mañana));

        //    string salida = "";

        //    foreach (IMensaje item in listaMsj)
        //    {
        //       salida += item.MostrarMsj();
        //    }

        //    Assert.IsTrue(salida.Length > 200);

        //}





    }//
}//
