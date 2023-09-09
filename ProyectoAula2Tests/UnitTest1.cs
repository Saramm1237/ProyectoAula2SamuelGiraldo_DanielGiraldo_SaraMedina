using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAula2;
using System;
using System.Collections.Generic;

namespace ProyectoAula2Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestAgregarIdeaDeNegocio()
        {
            // Arrange
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();

            // Act
            IdeaDeNegocio idea = Program.IngresarIdeaDeNegocio();
            ideas.Add(idea);

            // Assert
            Assert.AreEqual(1, ideas.Count);
        }

        [TestMethod]
        public void TestAgregarIntegrante()
        {
            // Arrange
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();
            IdeaDeNegocio idea = new IdeaDeNegocio
            {
                Codigo = "123",
                Nombre = "Idea de Negocio 1",
                Inversion = 1000
            };
            ideas.Add(idea);

            // Act
            Program.AgregarIntegrante(ideas, "123", new Integrante
            {
                Identificacion = "ABC123",
                Nombre = "Juan",
                Apellidos = "Perez",
                Rol = "CEO",
                Email = "juan@example.com"
            });

            // Assert
            Assert.AreEqual(1, ideas[0].Integrantes.Count);
        }

        [TestMethod]
        public void TestEliminarIntegrante()
        {
            // Arrange
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();
            IdeaDeNegocio idea = new IdeaDeNegocio
            {
                Codigo = "123",
                Nombre = "Idea de Negocio 1",
                Inversion = 1000
            };
            ideas.Add(idea);
            Program.AgregarIntegrante(ideas, "123", new Integrante
            {
                Identificacion = "ABC123",
                Nombre = "Juan",
                Apellidos = "Perez",
                Rol = "CEO",
                Email = "juan@example.com"
            });

            // Act
            Program.EliminarIntegrante(ideas, "123", "ABC123");

            // Assert
            Assert.AreEqual(0, ideas[0].Integrantes.Count);
        }

        [TestMethod]
        public void TestModificarInversion()
        {
            // Arrange
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();
            IdeaDeNegocio idea = new IdeaDeNegocio
            {
                Codigo = "123",
                Nombre = "Idea de Negocio 1",
                Inversion = 1000
            };
            ideas.Add(idea);

            // Act
            Program.ModificarInversion(ideas, "123", 1500);

            // Assert
            Assert.AreEqual(1500, ideas[0].Inversion);
        }
    }
}