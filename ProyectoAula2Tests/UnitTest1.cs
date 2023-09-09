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

       
     }

}