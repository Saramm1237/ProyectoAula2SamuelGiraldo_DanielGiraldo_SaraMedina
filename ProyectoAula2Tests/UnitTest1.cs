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
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();

            IdeaDeNegocio idea = Program.IngresarIdeaDeNegocio();
            ideas.Add(idea);

            Assert.AreEqual(1, ideas.Count);
        }

       
     }

}