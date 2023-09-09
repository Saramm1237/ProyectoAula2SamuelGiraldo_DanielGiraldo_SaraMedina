using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAula2;
using System;
using System.Collections.Generic;

namespace ProyectoAula2Test
{
    [TestClass]
    public class ProgramTests
    {
        private StringWriter consoleOutput;
        private TextReader originalConsoleInput;

        [TestInitialize]
        public void Setup()
        {
            consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

  
            originalConsoleInput = Console.In;
        }


        [TestMethod]
        public void TestIngresarIdeaDeNegocio()
        {
            string input = "Código de prueba\nNombre de prueba\n1000\n";
            Console.SetIn(new StringReader(input));

           
            IdeaDeNegocio idea = Program.IngresarIdeaDeNegocio();

            Assert.AreEqual("Código de prueba", idea.Codigo);
            Assert.AreEqual("Nombre de prueba", idea.Nombre);
            Assert.AreEqual(1000, idea.Inversion);
        }

        [TestMethod]
        public void TestIngresarIntegrante()
        {           
            string input = "ID de prueba\nNombre de prueba\nApellidos de prueba\nRol de prueba\nEmail de prueba\n";
            Console.SetIn(new StringReader(input));

            Integrante integrante = Program.IngresarIntegrante();

            Assert.AreEqual("ID de prueba", integrante.Identificacion);
            Assert.AreEqual("Nombre de prueba", integrante.Nombre);
            Assert.AreEqual("Apellidos de prueba", integrante.Apellidos);
            Assert.AreEqual("Rol de prueba", integrante.Rol);
            Assert.AreEqual("Email de prueba", integrante.Email);
        }

    }
}