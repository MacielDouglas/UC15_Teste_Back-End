using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutriVitta;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplicacaoCalculadora()
        {
            //Arrange - Prepara��o
            double primeiroNumero = 1.91; //altura
            double segundoNumero = 93; //peso

            double resultadoMult = 3.64; //adicionar apenas os primeiros tres digitos do resultado da multiplica��o
            double IMC = 25.54; // IMC= peso dividido pelo resultdoMult, apenas os tres primeiros digitos

            //Act - A��o
            var resultado = Calculadora.Multiplicacao(primeiroNumero);
            var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);

            //Assert - Verifica��o
            Assert.AreEqual(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            //Assert.AreEqual(29.71, resultDivisao);
            Assert.AreEqual(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
        }

        [DataTestMethod]
        [DataRow(1.68, 2.82, 68, 24.11)]
        [DataRow(1.55, 2.40, 43, 17.91)]
        [DataRow(2.05, 4.20, 137, 32.61)]
        [DataRow(1.77, 3.13, 92, 29.39)]

        public void CalculadoraImcLista(double primeiroNumero, double resultadoMult, double segundoNumero, double IMC)
        {
            //Act - A��o
            var resultado = Calculadora.Multiplicacao(primeiroNumero);
            var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);

            //Assert - Verifica��o
            Assert.AreEqual(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.AreEqual(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
        }
    }
}