using System;
using System.Collections.Generic;
using System.Text;
using Tester.Core;

namespace Tester.MSTest
{
    public class OperacoesTeste
    {
        [TestMethod]
        public void SomarDoisNumeros_Retornaresultado()
        {
            // arrange - organizar, preparar o teste
            double primeiroNumero = 10;
            double segundoNumero = 20;

            // act - agir - execução/chamada do método
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            // Assert - comportamento esperado, comportamento obtido
            Assert.AreEqual(30, resultado);
        }
    }
}
