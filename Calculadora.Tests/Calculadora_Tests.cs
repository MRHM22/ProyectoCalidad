using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora.Negocio;
using System;

//esto es un comentario para jenkins

namespace Calculadora.Tests
{
    [TestClass]
    public class Calculadora_Tests
    {
        Negocio.Metodo Cal = new Metodo();
        [DataRow(4, 4, 8)]
        [DataRow(5, 5, 10)]
        [DataRow(5, 4, 9)]
        [TestMethod]
        public void Suma_CalculaYRetornaResultado(float a, float b, float Esperado)
        {

            float Obtenido =Cal.Sumar(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(-4, -4, -8)]
        [DataRow(5, -5, 0)]
        [TestMethod]
        public void SumaNegativos_CalculaYRetornaResultado(float a, float b, float Esperado)
        {

            float Obtenido = Cal.Sumar(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(4, 4, 0)]
        [DataRow(7, 5, 2)]
        [DataRow(5, 4, 1)]
        [TestMethod]
        public void Resta_CalculaYRetornaResultado(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Reste(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(-4, 4, -8)]
        [DataRow(7, -5, 12)]
        [DataRow(-5, -4, -1)]
        [TestMethod]
        public void ResteNegativos_CalculaYRetornaResultado(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Reste(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow( 4, 4, 1)]
        [DataRow(25, 5, 5)]
        [DataRow(20, 4, 5)]
        [TestMethod]
        public void Divida_CalculaYRetornaResultado(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Divida(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(0, 4, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(20, 0, 0)]
        [TestMethod]
        public void Divida_RetorneCero(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Divida(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(4, 4, 16)]
        [DataRow(7, 5, 35)]
        [DataRow(5, 4, 20)]
        [TestMethod]
        public void Multiplique_CalculaYRetornaResultado(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Multiplique(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }

        [DataRow(4, 0, 0)]
        [DataRow(0, -5, 0)]
        [TestMethod]
        public void Multiplique_RetorneCero(float a, float b, float Esperado)
        {
            float Obtenido = Cal.Multiplique(a, b);

            Assert.AreEqual(Obtenido, Esperado);
        }
    }
}
