using Biblioteca.Matematica;
using NUnit.Framework;

namespace Biblioteca.Teste.MatematicaTeste
{
    internal class CalculoTeste
    {
        [Test]
        public void CalcularMediaPonderadaDeDuasNotas()
        {
            Assert.AreEqual(10.00000, Calculos.CalcularMediaPonderadaDeDuasNotas(10, 10, 10, 10, 5));
        }
    }
}
