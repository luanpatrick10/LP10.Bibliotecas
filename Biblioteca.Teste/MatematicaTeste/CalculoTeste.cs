using Biblioteca.Matematica;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Teste.MatematicaTeste
{
    internal class CalculoTeste
    {
        [Test]
        public void CalcularMediaPonderadaDeDuasNotas()
        {
            Calculos calculos = new Calculos();
            Assert.AreEqual(10.00000, calculos.CalcularMediaPonderadaDeDuasNotas(10, 10, 10, 10, 5));
        }
    }
}
