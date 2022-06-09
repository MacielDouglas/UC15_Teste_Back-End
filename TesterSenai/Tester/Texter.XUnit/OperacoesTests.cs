using System;
using System.Collections.Generic;
using System.Text;
using Tester.Core;

namespace Texter.XUnit
{
    public class OperacoesTests
    {
        [Fact]
        public void SomarDoisNumeros_RetornarResultado()
        {
            double primeiroNumero = 10;
            double segundoNumero = 20;

            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            Assert.Equal(30, resultado);
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]

        public void SomarDoisNumeros_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, double segundoNumero, double reultadoEsperado)
        {
            var resultadoDaSoma = Operacoes.Somar(primeiroNumero, segundoNumero);
            Assert.Equal(reultadoEsperado, resultadoDaSoma);
        }
    }
}
